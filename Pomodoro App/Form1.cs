using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.Diagnostics;
using Microsoft.Identity.Client;
using Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Graph.Models;
using System.Windows.Threading;
using static Pomodoro_App.JiraHelper;
using Atlassian.Jira;
using Windows.UI.Xaml.Controls;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Drawing.Text;
using Pomodoro_App.Models;

namespace Pomodoro_App
{
    public partial class Form1 : Form
    {
        int seconds;
        double musicStopTime;
        Stopwatch stopTimer = new Stopwatch();
        private System.Timers.Timer _timer = new System.Timers.Timer();
        private bool _requestStop = false;
        WindowsMediaPlayer musicPlayer = new WindowsMediaPlayer();
        string actuallySongPlayed;
        public List<string> blockedSites = new List<string>();
        private List<JiraIssue> issues = new List<JiraIssue>();
        private JiraIssue selectedIssue = null;
        private Statistic _statistic;

        [DllImport("user32")]
        public static extern void LockWorkStation();

        public Form1(Quote quote, Statistic statistic)
        {
            InitializeComponent();
            DateTime now = DateTime.Now.Date.AddMinutes(15).AddHours(15);
            dateTimePicker1.Value = now;
            FormClosing += new FormClosingEventHandler(Form1_FormClosing);
            Resize += new EventHandler(Form1_Resize);
            this.counter.Leave += Counter_Leave;
            this.author.Text = quote.Author;
            this.quote.Text = quote.QuoteText;
            this.quote.SelectionAlignment = HorizontalAlignment.Center;
            _statistic = statistic;
            this.statistic.Text = statistic.GetTodayStatistics();
        }

        private void Counter_Leave(object sender, EventArgs e)
        {
            if (counter.Text == "") return;

            DateTime endTime = DateTime.Now.AddMinutes(Convert.ToInt32(counter.Text));
            string endTimeStr = endTime.ToString();
            endtime3.Text = endTimeStr;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (blockWebsites_btn.Text == "Unblock")
            {
                MessageBox.Show("Uncheck blocking websites!");
                e.Cancel = true;
                return;
            }

            if (seconds > 0 || checkBox1.Checked == true)
            {
                var window = MessageBox.Show(
                    "Are you sure?",
                    "Some processes are pending",
                    MessageBoxButtons.YesNo);

                e.Cancel = (window == DialogResult.No);
            }
        }

        private void Form1_Resize( object sender, EventArgs e)
        {
            var form = new Form2(seconds);
            if (WindowState == FormWindowState.Minimized && seconds > 0 && timerCheckbox.Checked)
            {
                // Do some stuff
                form.ShowDialog();
                form.TopMost = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbCounter.Text = seconds--.ToString();
            if (seconds > 60)
            {
                label2.Text = "";
                int minutes = seconds / 60;
                int secondsLeft = seconds - (minutes * 60);
                lbCounter.Text = String.Format("{0} minutes {1} seconds", minutes.ToString(), secondsLeft.ToString());
                lbCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                lbCounter.Location = new System.Drawing.Point(195, 145);
            } else
            {
                label2.Text = "seconds";
                lbCounter.Location = new System.Drawing.Point(165, 126);
                lbCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                if (seconds == 10)
                {
                    WindowsMediaPlayer myplayer = new WindowsMediaPlayer();
                    myplayer.URL = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "clock_sound.mp3");
                    myplayer.controls.play();
                }
                if (seconds < 0)
                {
                    timer1.Stop();
                    counter.Enabled = true;
                    WindowsMediaPlayer myplayer = new WindowsMediaPlayer();
                    myplayer.URL = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "ping_sound.mp3");
                    myplayer.controls.play();
                    Thread.Sleep(200);
                    musicPlayer.controls.pause();
                    musicBtn_stop.Text = "Resume";
                    LockWorkStation();
                }
            }
            
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            seconds = Convert.ToInt32(counter.Text) * 60;
            counter.Enabled = false;
            DateTime endTime = DateTime.Now.AddMinutes(Convert.ToInt32(counter.Text));
            string endTimeStr = endTime.ToString();
            endtime3.Text = endTimeStr;
            _statistic.WriteStatistics(seconds);
            this.statistic.Text = _statistic.GetTodayStatistics();
            timer1.Start();

            var requestBody = new Microsoft.Graph.Users.Item.Presence.SetPresence.SetPresencePostRequestBody
            {
                SessionId = "22553876-f5ab-4529-bffb-cfe50aa89f87",
                Availability = "Busy",
                Activity = "Busy",
                ExpirationDuration = new TimeSpan(0,0,seconds),
            };

            if (jira_checkbox.Checked == true)
            {
                jiraWorklogRes.Visible = false;
                string result = await AddWorklogToJira(selectedIssue, seconds);
                if (result != string.Empty)
                {
                    jiraWorklogRes.Visible = true;
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {   
                long dateOfNot = dateTimePicker1.Value.Ticks;        
                long now = DateTime.Now.Ticks;                                              
                if (dateOfNot > now)                                        
                {
                    errorLabel.Visible = false;
                    dateTimePicker1.Enabled = false;
                    long difference = dateOfNot - now;
                    int miliseconds = (int)new TimeSpan(difference).TotalMilliseconds;

                    _timer.Interval = miliseconds;
                    _timer.Elapsed += ShowNotification;
                    _timer.Start();

                } else
                {
                    errorLabel.Visible = true;
                }
                  
            } else
            {
                dateTimePicker1.Enabled = true;
            }
        }

        private void ShowNotification(object sender, EventArgs e)
        {
            new ToastContentBuilder()
               .AddButton(new ToastButton("Idź do kalendarza", String.Empty)
                .AddArgument("ACTION_HAPPENED")
                )
               .AddButton(new ToastButton("Odłóż o 5 minut", String.Empty)
                .AddArgument("POSTPONED")
                )
               .AddInlineImage(new Uri(Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "freedom.png")))
               .AddText("KONIEC PRACY!")
               .AddText("Pora na podsumowanie i planowanie kolejnego dnia")
               .Show();

            Thread.Sleep(1000);
            WindowsMediaPlayer myplayer = new WindowsMediaPlayer();
            myplayer.URL = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "happy.mp3");
            myplayer.controls.play();

            if (_requestStop == false)
            {
                _timer.Interval = 60000;
                _timer.Start();
            } 
            ToastNotificationManagerCompat.OnActivated += ToastNotificationManagerCompat_OnActivated;
        }

        private void ToastNotificationManagerCompat_OnActivated(ToastNotificationActivatedEventArgsCompat e)
        {
            _requestStop = false;
            if (e.Argument == "ACTION_HAPPENED")
            {
                _requestStop = true;
                _timer.Stop();
                dateTimePicker1.Enabled = true;
                System.Diagnostics.Process.Start("https://calendar.google.com/calendar/u/0/r");
            }

            if (e.Argument == "POSTPONED")
            {
                _requestStop = true;
                _timer.Interval = 300000;
                _timer.Start();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
        }
        private void btn_Stop_Click(object sender, EventArgs e)
        {
            if (seconds > 0 && timer1.Enabled)
            {
                btn_Stop.Text = "Resume";
                timer1.Stop();
                counter.Enabled = true;
                stopTimer.Start();
            }
            else
            {
                btn_Stop.Text = "Pause";
                timer1.Start();
                counter.Enabled = false;
                stopTimer.Stop();
                double elapsed = stopTimer.Elapsed.TotalMilliseconds;
                DateTime currentEndTime = DateTime.Parse(endtime3.Text);
                currentEndTime = currentEndTime.AddMilliseconds(elapsed);
                endtime3.Text = currentEndTime.ToString();
            }
            
        }

        private void musicBtn_start_Click(object sender, EventArgs e)
        {
            if (musicSelect.Text == "" || musicSelect.Text == actuallySongPlayed) return;

            string musicToPlay = getTrackTitle(musicSelect.Text);

            musicPlayer.URL = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "music", musicToPlay);
            musicPlayer.controls.play();
            actuallySongPlayed = musicSelect.Text;
        }

        private string getTrackTitle(string musicSelect)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 10);

            switch(musicSelect)
            {
                case "Jazz":
                    return randomNumber > 5 ? "jazz.mp3" : "jazz1.mp3";
                case "Lo-Fi":
                    return randomNumber > 5 ? "lofi.mp3" : "lofi1.mp3";
                case "Chill":
                    return randomNumber > 5 ? "chill.mp3" : "chill1.mp3";
                default:
                    return "jazz.mp3";
            }
        }

        private void musicBtn_stop_Click(object sender, EventArgs e)
        {
            if (musicPlayer.playState == WMPPlayState.wmppsPlaying) {
                musicPlayer.controls.pause();
                musicBtn_stop.Text = "Resume";
                musicStopTime = musicPlayer.controls.currentPosition;
            } else if (musicPlayer.playState == WMPPlayState.wmppsPaused)
            {
                musicPlayer.controls.currentPosition = musicStopTime;
                musicPlayer.controls.play();
                musicBtn_stop.Text = "Pause";
            }
        }

        private void instagram_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            IEnumerable<string> insta = new string[] { "www.instagram.com", "instagram.com" };
            if (instagram_checkbox.Checked)
            {
                blockedSites.AddRange(insta);
            } else
            {
                blockedSites.RemoveAll(s => s.Contains("insta"));
            }
        }

        private void facebook_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            IEnumerable<string> face = new string[] { "www.facebook.com", "facebook.com" };
            if (facebook_checkbox.Checked)
            {
                blockedSites.AddRange(face);
            }
            else
            {
                blockedSites.RemoveAll(s => s.Contains("face"));
            }
        }

        private void wykop_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            IEnumerable<string> wykop = new string[] { "www.wykop.pl", "wykop.pl" };
            if (wykop_checkbox.Checked)
            {
                blockedSites.AddRange(wykop);
            }
            else
            {
                blockedSites.RemoveAll(s => s.Contains("wykop"));
            }
        }

        private void youtube_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            IEnumerable<string> youtube = new string[] { "www.youtube.com", "youtube.com" };
            if (youtube_checkbox.Checked)
            {
                blockedSites.AddRange(youtube);
            }
            else
            {
                blockedSites.RemoveAll(s => s.Contains("youtube"));
            }
        }

        private void blockWebsites_btn_Click(object sender, EventArgs e)
        {
            ProcessStartInfo proc = new ProcessStartInfo();
            proc.UseShellExecute = true;
            proc.WorkingDirectory = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "runner", "bin", "debug");
            proc.FileName = "runner";
            proc.Verb = "runas";

            if (blockWebsites_btn.Text == "Block")
            {
                youtube_checkbox.Enabled = false;
                facebook_checkbox.Enabled = false;
                wykop_checkbox.Enabled = false;
                instagram_checkbox.Enabled = false;
                blockedSites.Add("Block");
                proc.Arguments = String.Join(" ", blockedSites);
                blockWebsites_btn.Text = "Unblock";
            } else
            {
                youtube_checkbox.Enabled = true;
                facebook_checkbox.Enabled = true;
                wykop_checkbox.Enabled = true;
                instagram_checkbox.Enabled = true;
                blockedSites.Add("Unblock");
                proc.Arguments = String.Join(" ", blockedSites);
                blockWebsites_btn.Text = "Block";
            }
            try
            {
                System.Diagnostics.Process.Start(proc);
            }
            catch
            {
                errorLabel.Visible = false;
                errorLabel.Text = "Błąd podczas autoryzacji";
            }
        }

        private void chatGPT_btn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            ProcessStartInfo procStartInfo = new ProcessStartInfo()
            {
                WorkingDirectory = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "chatGPT"),
                WindowStyle = ProcessWindowStyle.Normal,
                FileName = "cmd.exe",
                Arguments = "/C node script.js",
            };
            process.StartInfo = procStartInfo;
            process.Start();
        }

        #region JIRA
        private async void jiraBtn_Click(object sender, EventArgs e)
        {
            jiraIssues.Items.Clear();
            jiraNegativeResult.Visible = false;
            jiraPositiveResult.Visible = false;

            var issues = await GetSprintIssues(this.jiraProjects.Text);
            if (issues != null)
            {
                this.issues = issues;
                jiraPositiveResult.Visible = true;
                jiraNegativeResult.Visible = false;
                foreach (var issue in issues)
                {
                   // add stories
                   if (issue.Fields.Status.Id == (int)Statuses.OPEN 
                        || issue.Fields.Status.Id == (int)Statuses.IN_PROGRESS 
                        || issue.Fields.Status.Id == (int)Statuses.CHANGE_AFTER_TEST
                        || issue.Fields.Status.Id == (int)Statuses.READY_FOR_CR
                        || issue.Fields.Status.Id == (int)Statuses.BOT_IN_PROGRESS
                        || issue.Fields.Status.Id == (int)Statuses.BOT_OPEN
                        || issue.Fields.Status.Id == (int)Statuses.BOT_CHANGE_AFTER_TEST)
                    {
                        jiraIssues.Items.Add($"{issue.Key}:{issue.Fields.Summary}");
                    }

                   // add subtasks
                   if (issue.Fields.Subtasks != null) 
                    {
                        foreach (var subtask in issue.Fields.Subtasks)
                        {
                            if (subtask.Fields.Status.Id == (int)Statuses.OPEN
                            || subtask.Fields.Status.Id == (int)Statuses.IN_PROGRESS
                            || subtask.Fields.Status.Id == (int)Statuses.CHANGE_AFTER_TEST
                            || subtask.Fields.Status.Id == (int)Statuses.READY_FOR_CR
                            || subtask.Fields.Status.Id == (int)Statuses.BOT_IN_PROGRESS
                            || subtask.Fields.Status.Id == (int)Statuses.BOT_OPEN
                            || subtask.Fields.Status.Id == (int)Statuses.BOT_CHANGE_AFTER_TEST)
                            {
                                jiraIssues.Items.Add($"SUBTASK: {subtask.Key}:{subtask.Fields.Summary}");
                            }
                        }
                    }
                }
            } else
            {
                jiraPositiveResult.Visible = false;
                jiraNegativeResult.Visible = true;
            }
        }

        private void jiraIssues_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] issueKey = this.jiraIssues.Text.Split(':');
            if (jiraIssues.Text.Contains("SUBTASK"))
            {
                string key = issueKey[1].Trim();
                if (issues.Find(l => l.Key == key) == null)
                {
                    foreach(var issue in issues)
                    {
                        if (issue.Fields.Subtasks == null) continue;
                        var subtask = issue.Fields.Subtasks.Find(l => l.Key == key);
                        if (subtask == null) continue;
                        selectedIssue = subtask;
                    }
                } 
            } 
            else
            {
                string key = issueKey[0].Trim();
                selectedIssue = issues.First(l => l.Key == key);
            }
        }

        private void issueLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (selectedIssue == null) return;
            System.Diagnostics.Process.Start($"https://all41.atlassian.net/browse/{selectedIssue.Key}");
        }

        private async void addWorklog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (selectedIssue == null) return;
            worklogResult.Visible = false;
            string result = await AddWorklogToJira(selectedIssue, 1800);
            if (result != string.Empty)
            {
                worklogResult.Visible = true;
            }
        }

        private async void sendToPR_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (selectedIssue == null) return;
            sendToPRStatus.Visible = false;
            string result = await SendToPRStatus(selectedIssue);
            if (result != string.Empty)
            {
                sendToPRStatus.Visible = true;
            }
        }

        private void jiraWorklogRes_Click(object sender, EventArgs e)
        {
            jiraWorklogRes.Visible = false;
        }

    #endregion JIRA


        #region azureAuth

        private string[] scopes = new string[] { "user.read", "calendars.read", "presence.ReadWrite" };
        // Below are the clientId (Application Id) of your app registration and the tenant information.
        // You have to replace:
        // - the content of ClientID with the Application Id for your app registration
        private const string ClientId = "411e08dd-f687-436d-ab7c-82880a9bdefe";

        private const string Tenant = "common"; // Alternatively "[Enter your tenant, as obtained from the Azure portal, e.g. kko365.onmicrosoft.com]"
        private const string Authority = "https://login.microsoftonline.com/" + Tenant;

        // The MSAL Public client app
        private static IPublicClientApplication PublicClientApp;

        private static string MSGraphURL = "https://graph.microsoft.com/v1.0/";
        private static AuthenticationResult authResult;

        private GraphServiceClient graphClient;

        private async void getToken_Click(object sender, EventArgs e)
        {
            try
            {
                graphClient = await SignInAndInitializeGraphServiceClient(scopes);
                User graphUser = await graphClient.Me.GetAsync();
                greet.Text = $"Hello {graphUser.DisplayName}!";



                //var result = await graphClient.Me.Calendar.Events.GetAsync((requestConfiguration) =>
                //{
                //    requestConfiguration.QueryParameters.Filter = $"startdatetime={DateTime.Now}";
                //});
                //logOut_btn.Visible = true;
            }
            catch (Exception ex)
            {
                greet.Text = ex.Message;
            }
        }

        private static async Task<string> SignInUserAndGetTokenUsingMSAL(string[] scopes)
        {
            // Initialize the MSAL library by building a public client application
            PublicClientApp = PublicClientApplicationBuilder.Create(ClientId)
                .WithAuthority(Authority)
                .WithRedirectUri("https://login.microsoftonline.com/common/oauth2/nativeclient")
                 .WithLogging((level, message, containsPii) =>
                 {
                     Debug.WriteLine($"MSAL: {level} {message} ");
                 }, LogLevel.Warning, enablePiiLogging: false, enableDefaultPlatformLogging: true)
                .Build();

            // It's good practice to not do work on the UI thread, so use ConfigureAwait(false) whenever possible.
            IEnumerable<IAccount> accounts = await PublicClientApp.GetAccountsAsync().ConfigureAwait(false);
            IAccount firstAccount = accounts.FirstOrDefault();

            try
            {
                authResult = await PublicClientApp.AcquireTokenSilent(scopes, firstAccount)
                                                  .ExecuteAsync();
            }
            catch (MsalUiRequiredException ex)
            {
                // A MsalUiRequiredException happened on AcquireTokenSilentAsync. This indicates you need to call AcquireTokenAsync to acquire a token
                Debug.WriteLine($"MsalUiRequiredException: {ex.Message}");

                authResult = await PublicClientApp.AcquireTokenInteractive(scopes)
                                                  .ExecuteAsync()
                                                  .ConfigureAwait(false);

            }
            return authResult.AccessToken;
        }

        private async static Task<GraphServiceClient> SignInAndInitializeGraphServiceClient(string[] scopes)
        {
            var tokenProvider = new TokenProvider(SignInUserAndGetTokenUsingMSAL, scopes);
            var authProvider = new BaseBearerTokenAuthenticationProvider(tokenProvider);
            var graphClient = new GraphServiceClient(authProvider, MSGraphURL);

            return await Task.FromResult(graphClient);
        }
    }
    #endregion
}

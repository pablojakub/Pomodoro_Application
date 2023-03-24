using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.ApplicationModel.Activation;
using WMPLib;
using System.Diagnostics;

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

        [DllImport("user32")]
        public static extern void LockWorkStation();

        public Form1()
        {
            InitializeComponent();
            DateTime now = DateTime.Now.Date.AddMinutes(15).AddHours(15);
            dateTimePicker1.Value = now;
            FormClosing += new FormClosingEventHandler(Form1_FormClosing);
            Resize += new EventHandler(Form1_Resize);
            this.counter.Leave += Counter_Leave; ;
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

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            seconds = Convert.ToInt32(counter.Text) * 60;
            counter.Enabled = false;
            DateTime endTime = DateTime.Now.AddMinutes(Convert.ToInt32(counter.Text));
            string endTimeStr = endTime.ToString();
            endtime3.Text = endTimeStr;
            timer1.Start();
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
               .AddButton(new ToastButton("Idź do Nozbe", String.Empty)
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
                System.Diagnostics.Process.Start("https://app.nozbe.com/#na");
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
                Process.Start(proc);
            }
            catch
            {
                errorLabel.Visible = false;
                errorLabel.Text = "Błąd podczas autoryzacji";
            }
        }

        private void chatGPT_btn_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo procStartInfo = new ProcessStartInfo()
            {
                WorkingDirectory = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "chatGPT"),
                WindowStyle = ProcessWindowStyle.Normal,
                FileName = "cmd.exe",
                Arguments = "/C npm start",
            };
            process.StartInfo = procStartInfo;
            process.Start();
        }
    }
    }

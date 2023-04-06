using Atlassian;
using Atlassian.Jira;
using Atlassian.Jira.OAuth;
using Azure;
using Microsoft.Graph.Models.Security;
using Microsoft.Graph.Models;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Diagnostics;
using System.Net.Http;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Text;

namespace Pomodoro_App
{
    class JiraHelper
    {
        public enum Statuses
        {
            OPEN = 1,
            IN_PROGRESS = 3,
            READY_FOR_CR = 10006,
            CLOSED = 6,
            CHANGE_AFTER_TEST = 10004,
            BOT_IN_PROGRESS = 10028,
            BOT_CHANGE_AFTER_TEST = 10106,
            BOT_OPEN = 10027,
        }
        private static string username = Properties.Settings.Default.ATLASSIAN_USERNAME;
        private static string password = Properties.Settings.Default.ATLASSIAN_API_KEY;
        private static string accountId = Properties.Settings.Default.ATLASSIAN_ACCOUNTID;
        private static string authString = $"{username}:{password}";
        private static string base64String = Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes(authString));
        private static string baseUrl = $"https://all41.atlassian.net";

        public async static Task<List<JiraIssue>> GetSprintIssues(string project)
        {
            string boardId = project == "BeeOffice" ? "2" : "29";
            string sprint = project == "BeeOffice" ? "475" : "480";
            string url = $"{baseUrl}//rest/agile/1.0/board/{boardId}/sprint/{sprint}/issue?jql=assignee={accountId}&fields=key&fields=summary&fields=status&fields=subtasks&fields=assignee";

            var request = new HttpRequestMessage(HttpMethod.Get, url);
            request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", base64String);
            HttpClient client = new HttpClient();
            var resp = await client.SendAsync(request);
                if (resp.IsSuccessStatusCode)
                {
                    string result = await resp.Content.ReadAsStringAsync();
                    JiraIssuesDTO response = JsonConvert.DeserializeObject<JiraIssuesDTO>(result);
                    if (project != "BeeOffice")
                    {
                        response.Issues.Add(new JiraIssue()
                        {
                            Id = String.Empty,
                            Key = "BOT-299",
                            Self = String.Empty,
                            Expand = String.Empty,
                            Fields = new Fields() { 
                                Summary = "Spotkania (planowanie, retro, przegląd, daily)", 
                                Status = new Status() 
                                { 
                                    Description = String.Empty,
                                    IconUrl = String.Empty,
                                    Name = String.Empty,
                                    Self = String.Empty,
                                    Id = 1,
                                } 
                            }

                        });
                    }
                return response.Issues;
                } 
                else
            {
                return null;
            }
        }

        public async static Task<string> AddWorklogToJira(JiraIssue jiraIssue, int seconds)
        {
            string url = $"{baseUrl}/rest/api/3/issue/{jiraIssue.Key}/worklog";
            WorklogDTO bodyData = new WorklogDTO()
            {
                timeSpentSeconds = seconds
            };
            var request = new HttpRequestMessage(HttpMethod.Post, url);
            request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", base64String);
            var json = JsonConvert.SerializeObject(bodyData);
            request.Content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpClient client = new HttpClient();
            var resp = await client.SendAsync(request);
            if (resp.IsSuccessStatusCode)
            {
                return "Added worklog";
            } else
            {
                return string.Empty;
            }
        }

        public async static Task<string> SendToPRStatus(JiraIssue jiraIssue)
        {
            string url = $"{baseUrl}/rest/api/3/issue/{jiraIssue.Key}/transitions";
            var prStatusId = jiraIssue.Key.Contains("BOT") ? "2" : "112";
            TransitionDTO bodyData = new TransitionDTO()
            {
                transition = new TransitionObj() { id = prStatusId } 
            };
            var request = new HttpRequestMessage(HttpMethod.Post, url);
            request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", base64String);
            var json = JsonConvert.SerializeObject(bodyData);
            request.Content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpClient client = new HttpClient();
            var resp = await client.SendAsync(request);
            if (resp.IsSuccessStatusCode)
            {
                return "Changed status";
            }
            else
            {
                return string.Empty;
            }
        }

        internal class JiraIssuesDTO
        {
            public string Expand { get; set; }
            public int StartAt { get; set; }
            public int MaxResult { get; set; }
            public int Total { get; set; }
            public List<JiraIssue> Issues { get; set; }
        }

        public class JiraIssue
        {
            public string Expand { get; set; }
            public string Self { get; set; }
            public string Key { get; set; }
            public string Id { get; set; }
            public Fields Fields { get; set; }
        }

        public class Fields
        {
            public string Summary { get; set; }
            public Status Status { get; set; }
            public List<JiraIssue> Subtasks { get; set; }
            public Assignee Assignee { get; set; }
        }

        public class Status
        {
            public string Name { get; set; }
            public string Self { get; set; }
            public string Description { get; set; }
            public string IconUrl { get; set; }
            public int Id { get; set; }
        }

        internal class Assignee
        {
            public string Self { get; set; }
            public string AccountId { get; set; }
        }

        internal class WorklogDTO
        {
            public int timeSpentSeconds { get; set; }
        }
        internal class TransitionDTO
        {
            public TransitionObj transition { get; set; }
        }

        internal class TransitionObj
        {
            public string id { get; set; }
        }
    }
}

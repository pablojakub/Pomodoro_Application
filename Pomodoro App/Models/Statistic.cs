using Microsoft.Graph.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pomodoro_App.Models
{
    public struct Statistic
    {
        public DateTime Date { get; set; }
        public int Minutes { get; set; }
        private static string _fileName => "statistics.json";
        public void ReadStatistic()
        {
            List<Statistic> statistics;
            ReadFile(out statistics, true);
            Statistic todayStatistic = statistics.FirstOrDefault(s => s.Date == DateTime.Today.Date);
            if (todayStatistic.Minutes == 0)
            {
                Date = DateTime.Today.Date;
                Minutes = 0;
            }
            else
            {
                Date = todayStatistic.Date;
                Minutes = todayStatistic.Minutes;
            }
        }

        private static void ReadFile(out List<Statistic> statistics, bool create = false)
        {
            var path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, _fileName);
            if (File.Exists(path))
            {
                var reader = new StreamReader(path);
                var json = reader.ReadToEnd();
                statistics = JsonConvert.DeserializeObject<List<Statistic>>(json);
                reader.Close();
                return;
            }

            statistics = new List<Statistic>() { 
                new Statistic() {  
                    Date = DateTime.Today.Date,
                    Minutes = 0,
                } 
            };
            if (File.Exists(path) == false && create)
            {
                string jsonString = JsonConvert.SerializeObject(statistics, Formatting.Indented);
                File.WriteAllText(path, jsonString);
            }
        }

        public string GetTodayStatistics()
        {
            if (Minutes == 0)
            {
                return "You don't have entries today";
            } 
            else
            {
                return $"You have {(Minutes / 60)} hours and {Minutes % 60} minutes focused time today. " +
                    $"Congratulations!";
            }
        }

        public void WriteStatistics(int seconds)
        {
            if (seconds == 0) { return; }
            Minutes = seconds / 60;

            List<Statistic> statistics;
            var path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, _fileName);
            ReadFile(out statistics);
            Statistic statisticToUpdate = statistics.Find(s => s.Date == DateTime.Today.Date);
            if (statisticToUpdate.Date == DateTime.MinValue)
            {
                statistics.Add(this);
            } else
            {
                int index = statistics.FindIndex(stat => stat.Date == DateTime.Today.Date);
                Minutes += statisticToUpdate.Minutes;
                statistics[index] = this;
            }
            string updatedJsonData = JsonConvert.SerializeObject(statistics, Formatting.Indented);
            File.WriteAllText(path, updatedJsonData);
        }
    }
}

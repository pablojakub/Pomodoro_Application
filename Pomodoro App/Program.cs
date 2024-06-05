using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Newtonsoft.Json;
using Pomodoro_App.Models;

namespace Pomodoro_App
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var quotes = ReadExcel();
            Statistic statistic = new Statistic();
            statistic.ReadStatistic();
            Random random = new Random();
            int randomNumber = random.Next(0, 13);
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Application.Run(new Form1(quotes[randomNumber], statistic, quotes));
        }

        private static List<Quote> ReadExcel()
        {
            List<Quote> result = new List<Quote>();

            string filePath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "quotes2.xlsx");
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb;
            Worksheet ws;

            wb = excel.Workbooks.Open(filePath);
            ws = wb.Worksheets[1];
            var quotes = ws.Range["A1:A13"];
            var authors = ws.Range["B1:B13"];

            foreach (var quote in quotes.Value)
            {
                result.Add(new Quote()
                {
                    QuoteText = quote.ToString(),
                });
            }

            int index = 0;
            foreach (var author in authors.Value)
            {
                result[index].Author = author.ToString();
                index++;
            }
            wb.Close(0);
            excel.Quit();
            return result;
        }
    }
}

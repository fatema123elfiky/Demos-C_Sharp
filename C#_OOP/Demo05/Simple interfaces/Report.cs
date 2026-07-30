using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo05.Simple_interfaces
{
    internal class Report : IPrintable
    {
       

        public string Title { get; set; }

        public DateTime Date { get; set; }

        public Report(string title, DateTime date)
        {
            Title = title;
            Date = date;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Report - title {Title} - {Date}");
        }
    }
}

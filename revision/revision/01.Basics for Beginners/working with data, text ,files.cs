using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revision._01.Basics_for_Beginners
{
    internal class workingWithData
    {
        public static void demo()
        {
            var datetime = new DateTime(2015, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;
            Console.WriteLine(now.Hour + ":" + now.Minute);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine();
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());

            Console.WriteLine();
            Console.WriteLine(now.ToString("yy-MM-dd hh:mm"));
        }

        public static void demo2()
        {
            var timeSpan = new TimeSpan(1, 2, 3);

            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = start.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("duration : " + duration);

            Console.WriteLine("minutes " + timeSpan.Minutes);
            Console.WriteLine("total minutes " + timeSpan.TotalMinutes);
        }
    }
}
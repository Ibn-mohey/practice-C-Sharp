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

    internal class workingWithStrings
    {
        public static void demo1()
        {
            /*
             * Tolower
             * Touppre
             * Trim
             * InexOf
             * LastIndexOf
             * substring(start) >>to the end
             * substring(start , length)
             * Replace()
             *
             *
             string.IsNullOrEmpty(str)
             string.IsNullOrWhiteSpace(srt)
             str.split(' ')
             */
            //string s = "1234";
            //int i = int.Parse(s);
            //int j = Convert.ToInt32(s);
        }

        public static void demo2()
        {
            var sentence = " this is long text this is long text this is long textthis is long textthis is long textthis is long textthis is long textthis is long textthis is long textthis is long text";
            var summary = StringUtility.SummerizeText(sentence, 25);
            Console.WriteLine(summary);
        }

        public static void stirngBuilder()
        {
            var builder = new StringBuilder();
            builder.Append('-', 10);
            Console.WriteLine(builder);
            /* append
             * append format
             * append line
             * replce
             * remove
             * insert(index , new string)
             *
             */
        }
    }
}
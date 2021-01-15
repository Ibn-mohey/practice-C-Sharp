using System;
using System.Globalization;

namespace mosh_csharp_basic.working_with_dates
{
    class DateT_exercise
    {
        public void dateTimeExercise()
        {
            //C# Sharp Exercises: Display the DateTime value in the formatted output

            //Write a C# Sharp program to extract the Date property and display the DateTime value in the formatted output.

            DateTime dateTime = new DateTime();

            DateTime onPoint = DateTime.Now;

            Console.WriteLine(onPoint.ToString("D"));

            DateTime dt1 = new DateTime(2016, 6, 8, 11, 49, 0);
            Console.WriteLine("Complete date: " + dt1.ToString());

            Console.WriteLine();
            DateTime today = new DateTime(2018, 08, 09, 11, 27, 00);
            Console.WriteLine("Complete Today Date and Time: " + today.ToString());

            //Get date-only portion of date, without its time.
            DateTime dateOnly = dt1.Date;

            Console.WriteLine();
            DateTime todayDateOnly = today.Date;

            Console.WriteLine("Short Date: " + dateOnly.ToString("d"));

            Console.WriteLine();
            Console.WriteLine("Short Date: " + todayDateOnly.ToString("d"));

            Console.WriteLine("Display date using 24-hour clock format:");

            Console.WriteLine(dateOnly.ToString("g"));
            Console.WriteLine(dateOnly.ToString("MM/dd/yyyy HH:mm"));

            Console.WriteLine();
            Console.WriteLine(todayDateOnly.ToString("g"));
            Console.WriteLine(todayDateOnly.ToString("MM/dd/yyyy HH:mm"));



            //C# Sharp DateTime: Exercise-7 with Solution

            //Write a C# Sharp program to get the time of day from a given array of date time values.

            //C# Sharp Exercises: Time of day from a given array of date time values 

            //string[] timeArray = new String[3]{ "09/09/2018", "10/09/2018", "11/09/2018" };
            //DateTime time = new DateTime();

            //for (int i = 0; i < timeArray.Length; i++)
            //{
            //    time = DateTime.Parse(timeArray[i]);

            //    Console.WriteLine(time);
            //}

            //DateTime[] dates = {DateTime.Now, new DateTime(2016, 8, 16, 9, 28, 0), new DateTime(2011, 8, 16, 9, 28, 0), new DateTime(2009, 8, 16, 9, 28, 0)};

            //foreach (var date in dates)
            //{
            //    Console.WriteLine("Day: {0:d} Time of Day: {1:g}", date.Date, date.TimeOfDay);
            //    Console.WriteLine("{0:d} Time: {0:t}\n", date);
            //}

            //DateTime localDate = DateTime.Now;
            //DateTime utcDate = DateTime.UtcNow;
            //String[] cultureNames = { "en-JM", "en-NZ", "fr-BE","de-CH", "nl-NL" };

            //foreach (var cultureName in cultureNames)
            //{
            //    CultureInfo culture = new CultureInfo(cultureName);
            //    Console.WriteLine("{0}:", culture.NativeName);

            //    Console.WriteLine("   Local date and time: {0}, {1:G}", localDate.ToString(culture), localDate.Kind);
            //    Console.WriteLine("   UTC date and time: {0}, {1:G}\n", utcDate.ToString(culture), utcDate.Kind);
            //}





        }
    }
}

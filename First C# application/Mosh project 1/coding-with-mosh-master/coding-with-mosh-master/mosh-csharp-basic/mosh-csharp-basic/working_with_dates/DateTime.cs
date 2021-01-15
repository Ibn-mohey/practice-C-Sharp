using System;

namespace mosh_csharp_basic.working_with_dates
{
    class DateT
    {
        public void dateTm()
        {
            //Date Time represent the exact date and time value
            
            //First way to declare date time 
            //DateTime dateTime = new DateTime();
            //var dateTimeWithVar = new DateTime();

            DateTime dateTime = new DateTime(2015, 1, 1);

            //DateTime.Now //Get the current Date time

            DateTime now = DateTime.Now;

            //DateTime today = DateTime.Today; //Get you today date

            DateTime today = DateTime.Today;

            //Console.WriteLine("Hour: " + now.Hour);
            //Console.WriteLine("Minute: " + now.Minute);

            //Date Time object in c# are immutable (Once you created them, you can not change them) 
            //But you can modifier them with Add

            DateTime tomorrow = now.AddDays(1);
            DateTime yesterday = now.AddDays(-1);

            Console.WriteLine(now.ToLongDateString()); //Output: e.g 03 September 2018
            Console.WriteLine(now.ToShortDateString()); //Output: 03/09/2018
            Console.WriteLine(now.ToLongTimeString()); //Output: 09:42:02
            Console.WriteLine(now.ToShortTimeString()); //Output: 09:42
            Console.WriteLine(now.ToString());//Output: Both date and Time e.g 03/09/2018 09:44:11
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:MM")); //You can even use format specifier to format how you want the and/or date time to be shown

            var dateTimes = new DateTime(2015, 1, 1);


            var newYear = dateTimes.AddYears(3);
            Console.WriteLine("New year: " + newYear);

        }
    }
}

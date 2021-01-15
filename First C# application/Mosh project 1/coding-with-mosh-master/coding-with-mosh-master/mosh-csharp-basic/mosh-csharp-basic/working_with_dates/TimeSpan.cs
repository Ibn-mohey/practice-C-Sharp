using System;

namespace mosh_csharp_basic.working_with_dates
{
    class TimeS
    {
        public void timespan()
        {

            //***Creating Time Span***
            //TimeSpan represent a lenght of time

            //TimeSpan time = new TimeSpan();
            //var time = new TimeSpan();

            TimeSpan time = new TimeSpan(1, 2, 3);
            TimeSpan time1 = new TimeSpan(1, 0, 0); //If you don't have a value of the minutes, hour, etc just pass zero

            //However you not going to be able to know what these number represent so the more readable way is to use:
            //we use the static methods on the time span structure which all start with from

            TimeSpan time2 = TimeSpan.FromHours(1); //This is more readable

            //Third is also a third way to write a day time object
            //If you have to two day objects and you subtact them the result is a time span e.g

            DateTime start = DateTime.Now;
            DateTime end = DateTime.Now.AddMinutes(2);

            TimeSpan duration = end - start; //Output: 2 mins

            Console.WriteLine("Duration: " + duration);

            ////***Properties * ***
            /// 
            ////Only we have a time span we can read it properties very easily
            ////Each time spand has a number of properties that can in pairs e.g

            Console.WriteLine("Minutes: " + time.Minutes); //Returns 2mins is the time
            Console.WriteLine("Total Minutes: " + time.TotalMinutes); //Returns adding 1hrs and 2mins and 3sec in total into minute

            //TimeSpan is also immutable (once you create it you can not change it) but also provide a couple of methods to provides its vaulable

            //******Add and Substract****
            Console.WriteLine("Add Example: " + time.Add(TimeSpan.FromMinutes(8))); //So your are adding 8mins to your orginal 2 mins before

            Console.WriteLine("Substract Example: " + time.Subtract(TimeSpan.FromMinutes(2)));

            //Convert to and from string with TimeSpan e.g to convert a time span to a string 
            //Simple use the ToString method

            Console.WriteLine("ToString: " + time.ToString()); //The reason ToString is greyed out is by default Console.WriteLine calls the ToString on any line you pass through it by default. 
                                                               //So you don't have to call it. But if you are not using Console.WriteLine and you need to convert a timespan to a string valuable simples call a ToString() method

            //How we convert from a string is by using the Parse Method
            //Which takes a string(lets you see both the time and date) e.g 

            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03")); //This wil automically apply a to string on our timespan object

        }
    }
}

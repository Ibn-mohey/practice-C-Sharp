using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mosh_csharp_basic.working_with_text.procedural_programming
{
    class ex5
    {
        /// <summary>
        /// Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00).
        /// A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, 
        /// display "Invalid Time". If the user doesn't provide any values, consider it as invalid time. 
        /// </summary>
        /// 
        public void exercise5()
        {
            Console.Write("Enter time: ");
            string input = Console.ReadLine();

            Console.WriteLine(IsValidTime(input));

            //if (String.IsNullOrWhiteSpace(input))
            //{
            //    Console.WriteLine("Invalid Time");
            //    return;
            //}

            //string[] components = input.Split(':');
            //if (components.Length != 2)
            //{
            //    Console.WriteLine("Invalid Time");
            //    return;
            //}

            //try
            //{
            //    int hour = Convert.ToInt32(components[0]);
            //    int minute = Convert.ToInt32(components[1]);

            //    if (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59)
            //        Console.WriteLine("Ok");
            //    else
            //        Console.WriteLine("Invalid Time");
            //}

            //catch (Exception)
            //{
            //    Console.WriteLine("Invalid Time");
            //}

            //if (String.IsNullOrWhiteSpace(input))
            //{
            //    Console.WriteLine("Invalid Time");
            //    return;
            //}

            ///***********************
            //string[] components = input.Split(':');
            //if (components.Length != 2)
            //{
            //    Console.WriteLine("Invalid Time");
            //    return;
            //}

            //try
            //{
            //    int hour = Convert.ToInt32(components[0]);
            //    int minute = Convert.ToInt32(components[1]);

            //    if (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59)
            //        Console.WriteLine("Ok");
            //    else
            //        Console.WriteLine("Invalid Time");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Invalid Time");
            //}
        }

        public bool IsValidTime(string time)
        {
            if (String.IsNullOrWhiteSpace(time))
                return false;

            string[] components = time.Split(':');
            if (components.Length != 2)
                return false;

            try
            {
                int hour = Convert.ToInt32(components[0]);
                int minute = Convert.ToInt32(components[1]);

                return (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59);
            }
            catch (Exception)
            {
                return false;
            }
        }
    }

}

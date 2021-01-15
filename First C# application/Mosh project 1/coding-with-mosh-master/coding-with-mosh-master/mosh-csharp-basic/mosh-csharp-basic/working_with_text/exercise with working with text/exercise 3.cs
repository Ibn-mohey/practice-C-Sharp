using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace mosh_csharp_basic.working_with_text.exercise_with_working_with_text
{
    public class exercise_3
    {
        public void Ex3()
        {
            //3 - Write a program and ask the user to enter a time value in the 24 - hour time format(e.g. 19:00). 
            //    A valid time should be between 00:00 and 23:59.
            //    If the time is valid, display "Ok"; otherwise, display "Invalid Time".
            //    If the user doesn't provide any values, consider it as invalid time. 


            Console.Write("Enter a time in 24 hour time format e.g 19:00: ");
            string input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalide Time");
                return;
            }

            string[] timeValues = input.Split(':');
            if (timeValues.Length != 2)
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            try
            {
                int hour = Convert.ToInt32(timeValues[0]);
                int minute = Convert.ToInt32(timeValues[1]);

                if (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59)
                {
                    Console.WriteLine("Ok");
                }

                else
                {
                    Console.WriteLine("Invalid Time");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Time");
            }

            //***Mosh answer***
            //Console.Write("Enter time: ");
            //string input = Console.ReadLine();

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

        }
    }
}

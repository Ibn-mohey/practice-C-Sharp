using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mosh_csharp_basic.working_with_text.procedural_programming
{
    class ex3
    {
        public void exercise3()
        {
            //1 - Write a program and ask the user to enter a few numbers separated by a hyphen. Work out if the numbers are consecutive.
            //    For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".

            Console.Write("Enter a few numbers (eg 1-2-3-4): ");
            string input = Console.ReadLine();

            List<int> numbers = new List<int>();

            foreach (string number in input.Split('-'))
                numbers.Add(Convert.ToInt32(number));

            bool isConsecutive = IsConsecutiveList(numbers);

            //numbers.Sort();

            //Boolean isConsecutive = true;
            //for (int i = 1; i < numbers.Count; i++)
            //{
            //    if (numbers[i] != numbers[i - 1] + 1)
            //    {
            //        isConsecutive = false;
            //        break;
            //    }
            //}

            //string message = isConsecutive ? "Consecutive" : "Not Consecutive";

            string message = isConsecutive ? "Consecutive" : "Not Consecutive";

            //Console.WriteLine(message);
            Console.WriteLine(message);
        }

        public bool IsConsecutiveList(List<int> list)
        {
            // Note that I've copied the list to a new array because I didn't want to call Sort()
            // impact the argument of this method. Caller of this method only expects a true/false answer 
            // as a result of this call. So, this method should not have a side-effect.
            int[] numbers = new int[list.Count];
            list.CopyTo(numbers);
            Array.Sort(numbers);

            for (var i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] != numbers[i - 1] + 1)
                    return false;
            }

            return true;
        }
    }
    
}

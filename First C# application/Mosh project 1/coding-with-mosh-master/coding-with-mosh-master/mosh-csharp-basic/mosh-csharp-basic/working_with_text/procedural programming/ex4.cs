using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mosh_csharp_basic.working_with_text.procedural_programming
{
    class ex4
    {
        /// <summary>
        /// Write a program and ask the user to enter a few numbers separated by a hyphen. If the user simply 
        /// presses Enter without supplying an input, exit immediately; otherwise, check to see if there are 
        /// any duplicates. If so, display "Duplicate" on the console.
        /// </summary>
        
        
        public void exercise4()
        {
            Console.Write("Enter a few numbers (eg 1-2-3-4): ");
            string input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
                return;

            List<int> numbers = new List<int>();
            foreach (var number in input.Split('-'))
                numbers.Add(Convert.ToInt32(number));

            //List<int> uniques = new List<int>();
            //bool includesDuplicates = false;
            //foreach (var number in numbers)
            //{
            //    if (!uniques.Contains(number))
            //        uniques.Add(number);
            //    else
            //    {
            //        includesDuplicates = true;
            //        break;
            //    }
            //}


            if (ContainsDuplicates(numbers))
                Console.WriteLine("Duplicate");
        }


        public bool ContainsDuplicates(List<int> numbers)
        {
            List<int> uniques = new List<int>();
            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                    uniques.Add(number);
                else
                    return true;
            }

            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mosh_csharp_basic.working_with_text.procedural_programming
{
    class ex2
    {
        /// <summary>
        /// Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may 
        /// include duplicates. Display the unique numbers that the user has entered.
        /// </summary>
        public void Exercise4()
        {
            List<int> numbers = new List<int>();
            const string quit = "Quit";
            int number = 0;

            while (true)
            {
                Console.Write("Enter a number or type \"Quit\": ");
                string input = Console.ReadLine();

                if (input == "quit")
                {
                    break;
                }

                numbers.Add(Convert.ToInt32(input));
            }

            List<int> uniqueNumbers = getUniqueNumbers(numbers); //We can simply can this inside the foreach block

            Console.WriteLine();
            Console.WriteLine("List of unique numbers user entered");
            foreach (var uniqueNumber in getUniqueNumbers(numbers))
            {
                Console.WriteLine(uniqueNumber);
            }
        }

        public List<int> getUniqueNumbers(List<int> numbers)
        {
            List<int> uniques = new List<int>();
            foreach (var unique in numbers)
            {
                if (!uniques.Contains(unique))
                {
                    uniques.Add(unique);
                }
            }

            return uniques;
        }
    }


}

using System;
using System.Collections.Generic;

namespace mosh_csharp_basic.working_with_text.exercise_with_working_with_text
{
    public class exercise_2
    {
        public void Ex2()
        {
            //2 - Write a program and ask the user to enter a few numbers separated by a hyphen.
            //    If the user simply presses Enter, without supplying an input, exit immediately;
            //    otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console.

            while (true)
            {
                Console.Write("Enter a few numbers followed by a hyphen e.g 1-2-3: ");
                string input = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(input))
                {
                    
                    break;
                }

                else
                {
                    List<int> numbers = new List<int>();

                    foreach (var singleInput in input.Split('-'))
                    {
                        numbers.Add(Convert.ToInt32(singleInput));
                    }

                    List<int> uniqueNumbersList = new List<int>();
                    Boolean duplicates = false;

                    foreach (var uniqueNumber in numbers)
                    {
                        if (!uniqueNumbersList.Contains(uniqueNumber))
                        {
                            uniqueNumbersList.Add(uniqueNumber);
                        }

                        else
                        {
                            duplicates = true;
                            break;
                        }
                    }

                    Console.WriteLine(duplicates ? "Duplicate" : "Not Duplicate");

                    break;
                }
            }

            //***Mosh's Answer**
            //Console.Write("Enter a few numbers (eg 1-2-3-4): ");
            //var input = Console.ReadLine();

            //if (String.IsNullOrWhiteSpace(input))
            //    return;

            //var numbers = new List<int>();
            //foreach (var number in input.Split('-'))
            //    numbers.Add(Convert.ToInt32(number));

            //var uniques = new List<int>();
            //var includesDuplicates = false;
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

            //if (includesDuplicates)
            //    Console.WriteLine("Duplicate");
        }
    }

}

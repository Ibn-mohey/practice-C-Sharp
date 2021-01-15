using System;
using System.Collections.Generic; //Used to working with list
using System.Globalization;

namespace mosh_csharp_basic.arrys_and_lists
{
    class lists
    {
        public void Lists()
        {
            List<int> firstNumbers = new List<int>();
            //var numbers = new List<int>();

            List<int> secondNumbers = new List<int>() { 1, 2, 3, 4 }; //If you know ahead of time what is in your list

            secondNumbers.Add(1); //add an object to the list

            secondNumbers.AddRange(new int[3] { 5, 6, 7 }); //add more than one object to the list

            foreach (var number in secondNumbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();

            Console.WriteLine("Index of 1: " + secondNumbers.IndexOf(1)); //IndexOf() Starts your search at the start of the list
            Console.WriteLine("Last Index of 1: " + secondNumbers.LastIndexOf(1)); //LastIndexOf() Starts your search at the end of the list
            Console.WriteLine("Count: " + secondNumbers.Count); //This is a property that returns the number of object in the list

            Console.WriteLine();
            Console.WriteLine("Removed just 1 of 1s in the list");
            Console.WriteLine("Remove: " + secondNumbers.Remove(1));

            foreach (var number in secondNumbers)
            {
                Console.WriteLine(number);
            }

            //Console.WriteLine("Remove: " + secondNumbers.Remove(1));

            //Say if we want to remove all the ones ine list



            //OUTPUT: Error we can not edit a list in a for each loop
            //foreach (var number in secondNumbers)
            //{
            //    if (number == 1)
            //    {
            //        secondNumbers.Remove(number);
            //    }
            //}
            Console.WriteLine();

            Console.WriteLine("List with all 1's removed");
            for (int i = 0; i < secondNumbers.Count; i++)
            {
                if (secondNumbers[i] == 1)
                {
                    secondNumbers.Remove(secondNumbers[i]);
                }
            }

            Console.WriteLine("Orginal List shown below");
            foreach (var number in secondNumbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();

            secondNumbers.Clear();
            Console.WriteLine("Count: " + secondNumbers.Count);
        }
    }
}

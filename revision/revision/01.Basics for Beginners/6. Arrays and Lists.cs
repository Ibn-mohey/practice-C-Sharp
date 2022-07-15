using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revision._01.Basics_for_Beginners
{
    internal class listAndArrays
    {
        public static void demo1()
        {
            var numbers = new int[] { 3, 7, 9, 2, 14, 6 };
            Console.WriteLine("Length: " + numbers.Length);

            Console.WriteLine(Array.IndexOf(numbers, 9));

            Console.WriteLine("\n-----");

            Array.Clear(numbers, 0, 2);
            Console.WriteLine("clear");
            Array.ForEach(numbers, Console.WriteLine);
            Console.WriteLine("sort \n-----");
            Array.Sort(numbers);
            Array.ForEach(numbers, Console.WriteLine);
        }

        public static void demo2()
        {
            var numbers = new List<int>() { 1, 2, 3, 4 };
            numbers.Add(1);
            numbers.AddRange(new int[3] { 5, 6, 7 });

            Console.WriteLine(String.Join("; ", numbers));
            Console.WriteLine(numbers.IndexOf(1));
            Console.WriteLine(numbers.LastIndexOf(1));
        }
    }
}
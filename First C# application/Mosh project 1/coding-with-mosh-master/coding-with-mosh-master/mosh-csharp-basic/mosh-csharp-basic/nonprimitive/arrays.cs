using System;

namespace mosh_csharp_basic.nonprimitive
{
    public class CSharpArrays
    {
        public void CSharpArray()
        {
            int[] numbers = new int[3];
            //var numbers = new int [3]; //make the code shorter

            numbers[0] = 1;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            bool[] flags = new bool[3];
            flags[0] = true;

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[02]);


            string[] names = new string[3] { "Bart", "Lisa", "jack" };
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
        }
    }
}

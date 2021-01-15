using System;

namespace mosh_csharp_basic.control_flow.Iteration_statements
{
    class foreachloop
    {
        public void ForEachLoop()
        {
            //string name = "Peter Coker";

            //for (int i = 0; i < name.Length; i++)
            //{
            //    Console.WriteLine(name[i]);
            //}

            //foreach (char character in name)
            //{
            //    Console.WriteLine(character);
            //}

            int[] numbers = new int[] {1, 2, 3, 4};

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}

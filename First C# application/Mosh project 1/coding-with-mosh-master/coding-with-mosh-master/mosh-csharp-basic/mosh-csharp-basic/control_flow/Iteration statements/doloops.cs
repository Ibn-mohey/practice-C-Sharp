using System;

namespace mosh_csharp_basic.control_flow.Iteration_statements
{
    class doloops
    {
        public void DoLoop()
        {
            Console.Write("Please Enter a number ");
            int no = int.Parse(Console.ReadLine());
            int whileCount = 0;
            int doCount = 0;

            while (whileCount < no)
            {
                Console.WriteLine("While Loop Number : {0} \n", whileCount);
                whileCount++;
            }

            do
            {
                Console.WriteLine("Do While loop : {0} \n", doCount);
                doCount++;
            } while (doCount < no);

        }
    }
}

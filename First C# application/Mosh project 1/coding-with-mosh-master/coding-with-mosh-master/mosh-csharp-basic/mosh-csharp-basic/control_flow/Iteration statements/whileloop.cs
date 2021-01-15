using System;

namespace mosh_csharp_basic.control_flow.Iteration_statements
{
    class whileloop
    {
        public void WhileLoop()
        {
            //Use a for loop when you know the number of iteration
            //for (int i = 0; i < 10; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //Use the while loop when you don't know how many number of times you are going to do a iteration
            //int i = 0;
            //while (i <= 10)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //    i++;
            //}

            while (true)
            {
                Console.Write("Type your name: ");
                string input = Console.ReadLine();

                //if (string.IsNullOrWhiteSpace(input))
                //{
                //    break;
                //}

                //else
                //{
                //    Console.WriteLine("@Echo: " + input);
                //}

                if (!string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@Echo: " + input);
                    continue; //continues to the begin of the loop 
                }

                else
                {
                    break;
                }


            }

        }
    }
}

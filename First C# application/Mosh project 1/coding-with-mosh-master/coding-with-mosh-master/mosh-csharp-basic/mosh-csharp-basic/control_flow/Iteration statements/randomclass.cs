using System;

namespace mosh_csharp_basic.control_flow.Iteration_statements
{
    class randomclass
    {
        public void RandomClass()
        {
          Random random = new Random();
          const int passwordLength = 10;
          char[] buffer = new char[passwordLength];
        
            for (int i = 0; i < passwordLength; i++)
            {
                //Console.WriteLine(random.Next()); //Line of 10 random number 
                //Console.WriteLine(random.Next(i));//list of random numbers from 1 to 10
               
                //Console.WriteLine(random.Next(1, 10));

                //Console.Write((char)random.Next(97, 122));

                Console.WriteLine((char)('a' + random.Next(0, 26)));

                buffer[i] = (char) ('a' + random.Next(0, 26));
            }

            //string password = ""; //Common way of declaring a string 
            string passwords = new string(buffer); //Another way of declaring a string


            Console.WriteLine(passwords);
            //Console.WriteLine((int)'a');
        }
    }
}

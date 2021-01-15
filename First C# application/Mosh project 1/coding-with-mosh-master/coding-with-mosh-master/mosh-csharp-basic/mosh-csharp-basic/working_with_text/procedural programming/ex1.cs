
using System;
using System.Collections.Generic;

namespace mosh_csharp_basic.working_with_text.procedural_programming
{
    class ex1
    {

        // <summary>
        //Ask the user to enter their name.Use an array to reverse the name and then store the result in a new string. 
        //Display the reversed name on the console.
        //</summary>
        public void Exercise2()
        {
            Console.Write("What's your name? ");
            string name = Console.ReadLine();

            string reversed = ReverseName(name); //We can our new method

            //char[] array = new char[name.Length];
            //for (int i = name.Length; i > 0; i--)
            //array[name.Length - i] = name[i - 1];



            Console.WriteLine("Reversed name: " + reversed);

        }

        public static string ReverseName(string name)
        {
            char[] array = new char[name.Length];
            for (int i = name.Length; i > 0; i--)
                array[name.Length - i] = name[i - 1];

            //This a bit of noise becuase the main of the method ReverseName that what is coming out 
            //Out of this ReverseName method is the name so we don't need ot store it in separte variable

            //string reversed = new string(array);
            //return reversed;

            //This way the method is shorter and eassier to understand
            return new string(array);
        }

    }
}

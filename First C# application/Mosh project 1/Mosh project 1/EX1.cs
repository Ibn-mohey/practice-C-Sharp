using System;

namespace Mosh_project_1.exercises

{
    public class EX1
    {
        static void EX11()
        {
            /*1- Write a program and ask the user to enter a number.
             The number should be between 1 to 10. If the user enters a valid number, display "Valid" on the console. 
             Otherwise, display "Invalid". (This logic is used a lot in applications where values entered into input boxes need to be validated.) */
            
            Console.WriteLine("number plz: "); 
            var inputt = Console.Read();

            if (inputt > 1 && inputt < 10)
            {
                Console.WriteLine("Valid");
            }
        }
    }
}
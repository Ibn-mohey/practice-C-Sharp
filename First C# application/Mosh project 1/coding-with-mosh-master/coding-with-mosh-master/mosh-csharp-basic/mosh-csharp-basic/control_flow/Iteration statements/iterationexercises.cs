using System;

namespace mosh_csharp_basic.control_flow.Iteration_statements
{
    class iterationexercises
    {
        public void Exercise1()
        {
            //1 - Write a program to count how many numbers 
            //between 1 and 100 are divisible by 3 with no remainder.Display the count on the console.

            int count = 0, divisbleLimit = 100;
            const int Divisble = 3;

            for (int i = 1; i <= divisbleLimit; i++)
            {
                if (i % Divisble == 0)
                {
                    count++;
                }
            }

            Console.WriteLine("Count: {0}", count);

            //var count = 0;
            //for (var i = 1; i <= 100; i++)
            //{
            //    if (i % 3 == 0)
            //        count++;
            //}
            //Console.WriteLine("There are {0} numbers divisible by 3 between 1 and 100.", count);

        }

        public void Exercise2()
        {
            //2- Write a program and continuously ask the user to enter a number or "ok" to exit. 
            //Calculate the sum of all the previously entered numbers and display it on the console.

            int sum = 0;
            string loopExitWord = "ok";

            while (true)
            {
                Console.Write(@"Enter a number or ""ok"": ");
                string input = Console.ReadLine();

                if (input == loopExitWord)
                {
                    break;
                }

                sum += Convert.ToInt32(input);
            }

            Console.WriteLine("Sum of all previously entered numbers: " + sum);

            //var sum = 0;
            //while (true)
            //{
            //    Console.Write("Enter a number (or 'ok' to exit): ");
            //    var input = Console.ReadLine();

            //    if (input.ToLower() == "ok")
            //        break;

            //    sum += Convert.ToInt32(input);
            //}
            //Console.WriteLine("Sum of all numbers is: " + sum);

        }

        public void Exercise3()
        {
            //3- Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console. 
            //For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.

            int number, factorial = 1;

            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            Console.WriteLine("{0}! = {1}", number, factorial);
        }

        public void Exercise4()
        {
            //4- Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number.  
            //If the user guesses the number, display “You won"; otherwise, display “You lost".
            //(To make sure the program is behaving correctly, you can display the secret number on the console first.) 

            int secretNumber = new Random().Next(1, 10);
            int guessNumber;

            Console.WriteLine("The secret number: " + secretNumber);

            for (int i = 1; i <= 4; i++)
            {
                Console.Write("Guess a number between 1 and 10, numbers of guess {0}/4: ", i);
                guessNumber = Convert.ToInt32(Console.ReadLine());


                if (guessNumber == secretNumber)
                {
                    Console.WriteLine("You won");
                    return;
                }
            }

            Console.WriteLine("You lost");
        }

        public void Exercise5()
        {
            //5- Write a program and ask the user to enter a series of numbers separated by comma.  
            //Find the maximum of the numbers and display it on the console.
            //For example, if the user enters “5, 3, 8, 1, 4", the program should display 8. 

            //Console.Write("Enter commoa separated numbers: ");
            //var input = Console.ReadLine();

            //var numbers = input.Split(',');

            ////// Assume the first number is the max 
            //var max = Convert.ToInt32(numbers[0]);

            //foreach (var str in numbers)
            //{
            //    var number = Convert.ToInt32(str);
            //    if (number > max)
            //        max = number;
            //}

            //Console.WriteLine("Max is " + max);


            Console.Write("Enter a series of number or press enter to exit: ");
            string userInput = Console.ReadLine();
            string[] numbers = userInput.Split(',');

            //Assume user inputs max number as max
            int maxNumber = int.Parse(numbers[0]);

            foreach (string userInputs in numbers)
            {
                int number = Convert.ToInt32(userInputs);
                if (number > maxNumber)
                {
                    maxNumber = number;
                }

            }

            Console.WriteLine("Max Number is " + maxNumber);

        }



    }
}

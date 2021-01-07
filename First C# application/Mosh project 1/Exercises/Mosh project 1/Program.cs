using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh_project_1
{
    class Program
    {
        static void Main(string[] args)
        {

            /*1- Write a program and ask the user to enter a number. The number should be between 1 to 10.
             If the user enters a valid number, display "Valid" on the console. Otherwise, display "Invalid". 
             (This logic is used a lot in applications where values entered into input boxes need to be validated.)
             */

            //Console.WriteLine("enter your number ");
            //var number = Convert.ToUInt32(Console.ReadLine());
            //Console.WriteLine((number >= 1 && number <= 10) ? "valid" : "invalid");

            //Console.WriteLine("__________");
            ///*
            //2- Write a program which takes two numbers from the console and displays the maximum of the two.
            //*/
            //Console.WriteLine("enter your first numbers ");
            //var first = Convert.ToInt32(Console.ReadLine());


            //Console.WriteLine("enter your second numbers ");
            //var second = Convert.ToInt32(Console.ReadLine());

            //if (first == second)
            //{
            //    Console.WriteLine("values are the same");
            //}
            //else if (first > second)
            //{
            //    Console.WriteLine("first number(" + first + ") is the highest");
            //}
            //else
            //{
            //    Console.WriteLine("second number(" + second + ") is the highest");
            //}

            //Console.WriteLine("__________");
            ///*
            //3- Write a program and ask the user to enter the width and height of an image. Then tell if the image is landscape or portrait.
            //*/
            //Console.WriteLine("enter image width ");
            //var width = Convert.ToInt32(Console.ReadLine());


            //Console.WriteLine("enter image height ");
            //var height = Convert.ToInt32(Console.ReadLine());

            //if (width == height)
            //{
            //    Console.WriteLine("values are the same");
            //}
            //else if (width > height)
            //{
            //    Console.WriteLine("landscape");
            //}
            //else
            //{
            //    Console.WriteLine("portrait");
            //}

            //Console.WriteLine("__________");
            /*
            4- Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic.

            Write a program that asks the user to enter the speed limit. 
            Once set, the program asks for the speed of a car. 
            If the user enters a value less than the speed limit, program should display Ok on the console. 
            If the value is above the speed limit, the program should calculate the number of demerit points. 
            For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console. 
            If the number of demerit points is above 12, the program should display License Suspended.
            */

            //Console.WriteLine("enter the speed limit: ");
            //var speedLimit = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("enter the speed of the car: ");
            //var carSpeed = Convert.ToInt32(Console.ReadLine());

            //if (carSpeed < speedLimit)
            //{
            //    Console.WriteLine("OK");
            //}
            //else
            //{
            //    var demeritPoints = (carSpeed - speedLimit) / 5;
            //    if (demeritPoints > 12)

            //    {
            //        Console.WriteLine("License Suspended.");
            //    }
            //    else
            //    {
            //    }
            //}

            //Console.WriteLine("__________");

            /*
            1- Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. Display the count on the console.
            */
            // var count = 0;
            // for (var i = 1; i <= 100; i++)
            //     if (i % 3 == 0) count++;
            //
            // Console.WriteLine(count);
            //
            // Console.WriteLine("__________");
            // /*
            // 2- Write a program and continuously ask the user to enter a number or "ok" to exit. Calculate the sum of all the previously entered numbers and display it on the console.
            // */
            // var oldNumber = 0;
            // while (true)
            // {
            //     Console.WriteLine("enter number: ");
            //     var newNumber = Console.ReadLine();
            //     if (string.IsNullOrEmpty(newNumber))
            //     {
            //         break;
            //     }
            //     var sum = oldNumber + Convert.ToInt32(newNumber);
            //     Console.WriteLine(sum);
            //     oldNumber = sum;
            //     
            // }
            //
            // Console.WriteLine("__________");
            /*
            3- Write a program and ask the user to enter a number. 
            Compute the factorial of the number and print it on the console. 
            For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
            */

            // Console.WriteLine("enter number: ");
            // var fact = 1;
            //
            // var num = Convert.ToInt32(Console.ReadLine());
            // for (int i = 1; i < num+1; i++)
            // {
            //     fact = i * fact;
            // }
            // Console.WriteLine(fact);
            // Console.WriteLine("__________");

            /*
            4- Write a program that picks a random number between 1 and 10. 
            Give the user 4 chances to guess the number. 
            If the user guesses the number, display “You won"; 
            otherwise, display “You lost". 
            (To make sure the program is behaving correctly, you can display the secret number on the console first.)
            */

            // Console.WriteLine("Try to guess a number from 1 to 10. You have 4 chances");
            // Random rnd = new Random();
            // var randomNumber = rnd.Next(1, 10);
            // for (int i = 0; i < 5; i++)
            // {
            //     Console.Write("Try #{0}: ", i);
            //     var answer = Convert.ToInt32(Console.ReadLine());
            //
            //     if (answer == randomNumber)
            //     {
            //         Console.WriteLine("You won!");
            //         break;
            //     }
            //     else if (i == 4)
            //     {
            //         Console.WriteLine("Yow lost");
            //     }
            // }
            //
            // Console.WriteLine("__________");
            /*
            5- Write a program and ask the user to enter a series of numbers separated by comma. 
            Find the maximum of the numbers and display it on the console. 
            For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
            */
            // Console.Write("Enter a series of numbers, seperated by commas: ");
            // var nums = Console.ReadLine();
            //
            // var numbers = nums.Split(',');
            //
            // var max = Convert.ToInt32(numbers[0]);
            //
            // foreach (var str in numbers)
            // {
            //     var number = Convert.ToInt32(str);
            //     if (number > max)
            //         max = number;
            // }
            //
            // Console.WriteLine("Max is " + max);
            //
            //
            //
            //
            // Console.WriteLine("__________");

            /*
            1- When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.

            If no one likes your post, it doesn't display anything.
            If only one person likes your post, it displays: [Friend's Name] likes your post.
            If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
            If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.
            Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). Depending on the number of names provided, display a message based on the above pattern.
            */






            /*
            2- Write a program and ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. Display the reversed name on the console.
            */




            /*
            3- Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
            */




            /*
            4- Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may include duplicates. Display the unique numbers that the user has entered.
            */




            /*
            5- Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display the 3 smallest numbers in the list.
            */




            /*
            1 - Write a program and ask the user to enter a few numbers separated by a hyphen.Work out if the numbers are consecutive.For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".
            */



            /*
            2 - Write a program and ask the user to enter a few numbers separated by a hyphen.If the user simply presses Enter, without supplying an input, exit immediately; otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console.
            */




            /*
            3 - Write a program and ask the user to enter a time value in the 24 - hour time format (e.g. 19:00). A valid time should be between 00:00 and 23:59.If the time is valid, display "Ok"; otherwise, display "Invalid Time".If the user doesn't provide any values, consider it as invalid time.
            */




            /*
            4 - Write a program and ask the user to enter a few words separated by a space.Use the words to create a variable name with PascalCase. For example, if the user types: "number of students", display "NumberOfStudents".Make sure that the program is not dependent on the input. So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".
            */




            /*
            5 - Write a program and ask the user to enter an English word.Count the number of vowels(a, e, o, u, i) in the word. So, if the user enters "inadequate", the program should display 6 on the console.
            */





            /*
            1- Write a program that reads a text file and displays the number of words.
            */




            /*
            2- Write a program that reads a text file and displays the longest word in the file.
             */












        }
    }
}

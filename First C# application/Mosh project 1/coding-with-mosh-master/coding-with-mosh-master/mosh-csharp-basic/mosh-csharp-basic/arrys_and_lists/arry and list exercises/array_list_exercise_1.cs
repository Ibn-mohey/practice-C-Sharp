using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;

namespace mosh_csharp_basic.arrys_and_lists
{
    class array_list_exercise
    {
        public void ArrayAndListEx()
        {
            //1 - When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.

            //    If no one likes your post, it doesn't display anything.
            //    If only one person likes your post, it displays: [Friend's Name] likes your post.
            //    If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
            //    If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.

            //    Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). 
            //    Depending on the number of names provided, display a message based on the above pattern.

            //List<String> names = new List<string>();
            //string input;

            //do
            //{
            //    Console.Write("Enter a name or hit ENTER to quit: ");
            //    input = Console.ReadLine();

            //    if (string.IsNullOrWhiteSpace(input))
            //    {
            //        break;
            //    }

            //    names.Add(input);

            //} while (true);

            //if (names.Count == 1)
            //{
            //    Console.WriteLine("{0} likes your post", names[0]);
            //}

            //else if (names.Count == 2)
            //{
            //    Console.WriteLine("{0}, {1} likes your post", names[0], names[1]);
            //}

            //else if (names.Count > 2)
            //{
            //    Console.WriteLine("{0}, {1} and {2} others likes your post", names[0], names[1], names.Count - 2);
            //}

            //else
            //{
            //    Console.WriteLine();
            //}

            //var names = new List<string>();

            //while (true)
            //{
            //    Console.Write("Type a name (or hit ENTER to quit): ");

            //    var input = Console.ReadLine();
            //    if (String.IsNullOrWhiteSpace(input))
            //        break;
            //    names.Add(input);
            //}

            //if (names.Count > 2)
            //    Console.WriteLine("{0}, {1} and {2} others like your post", names[0], names[1], names.Count - 2);
            //else if (names.Count == 2)
            //    Console.WriteLine("{0} and {1} like your post", names[0], names[1]);
            //else if (names.Count == 1)
            //    Console.WriteLine("{0} likes your post.", names[0]);
            //else
            //    Console.WriteLine();


            //2 - Write a program and ask the user to enter their name. 
            //    Use an array to reverse the name and 
            //    then store the result in a new string.
            //    Display the reversed name on the console.

            //****Answer*****
            //Console.Write("What's your name? ");
            //string name = Console.ReadLine();

            //char[] array = new char[name.Length];
            //for (int i = name.Length; i > 0; i--)
            //    array[name.Length - i] = name[i - 1];

            //string reversed = new string(array);
            //Console.WriteLine("Reversed name: " + reversed);


            //string name;

            //Console.Write("Enter your name: ");
            //name = Console.ReadLine();

            //char[] array = new char[name.Length];

            //for (int i = name.Length; i > 0; i--)
            //{
            //    array[name.Length - i] = name[i - 1];
            //}

            //string reversed = new string(array);

            //Console.WriteLine("Reversed name: " + reversed);



            //3 - Write a program and ask the user to enter 5 numbers.
            //    If a number has been previously entered, display an error message and ask the user to re-try. 
            //    Once the user successfully enters 5 unique numbers, sort them and display the result on the console.

            //List<int> numbers = new List<int>();
            //const int Limit = 5;
            //int input;

            //do
            //{
            //    Console.Write("Enter a number: ");
            //    input = Convert.ToInt32(Console.ReadLine());

            //    if (numbers.Contains(input))
            //    {
            //        Console.WriteLine();
            //        Console.WriteLine("You have enter this number before");
            //        Console.WriteLine("Please re-enter a unique number...");
            //        Console.WriteLine();
            //        continue;
            //    }

            //    numbers.Add(input);

            //} while (numbers.Count < Limit);

            //numbers.Sort();

            //Console.WriteLine("\nSorted List:");

            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            ////***Mosh Answers***
            //var numbers = new List<int>();

            //while (numbers.Count < 5)
            //{
            //    Console.Write("Enter a number: ");
            //    var number = Convert.ToInt32(Console.ReadLine());
            //    if (numbers.Contains(number))
            //    {
            //        Console.WriteLine("You've previously entered " + number);
            //        continue;
            //    }

            //    numbers.Add(number);
            //}

            //numbers.Sort();

            //foreach (var number in numbers)
            //    Console.WriteLine(number);

            //4 - Write a program and ask the user to continuously enter a number or type "Quit" to exit. 
            //    The list of numbers may include duplicates.
            //    Display the unique numbers that the user has entered.

            List<int> numbers = new List<int>();
            const string quit = "Quit";
            int number = 0;
            List<int> uniqueNumbers = new List<int>();

            ////***First Approach****
            //while (true)
            //{
            //    Console.Write("Enter a number or type \"Quit\": ");
            //    string input = Console.ReadLine();

            //    if (input == quit)
            //    {
            //       break;
            //    }

            //    numbers.Add(Convert.ToInt32(input));
            //}

            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    if (numbers.Contains(i))
            //    {
            //        numbers.Remove(numbers[i]);
            //    }
            //}

            //Console.WriteLine();
            //Console.WriteLine("List of unique numbers user entered");
            //foreach (var uniqueNumber in numbers)
            //{
            //    Console.WriteLine(uniqueNumber);
            //}


            //***Second Approach**
            while (true)
            {
                Console.Write("Enter a number or type \"Quit\": ");
                string input = Console.ReadLine();

                if (input == quit)
                {
                    break;
                }

                numbers.Add(Convert.ToInt32(input));
            }


            foreach (var unique in numbers)
            {
                if (!uniqueNumbers.Contains(unique))
                {
                    uniqueNumbers.Add(unique);
                }
            }

            Console.WriteLine();
            Console.WriteLine("List of unique numbers user entered");
            foreach (var uniqueNumber in uniqueNumbers)
            {
                Console.WriteLine(uniqueNumber);
            }


            //5 - Write a program and ask the user to supply a list of comma separated numbers(e.g 5, 1, 9, 2, 10). 
            //    If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try;
            //    otherwise, display the 3 smallest numbers in the list.

            //List<int> numbers = new List<int>();
            //List<int> lowestNumbers = new List<int>();

            //string number, formattedLowestNumbers = string.Join(",", lowestNumbers);

            ////string formattedNumbers = string.Join(",", numbers), 

            //int count = 0;

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write("Enter a number: ");
            //    number = Console.ReadLine();

            //    //if ((numbers.Count > 5) || ((string.IsNullOrWhiteSpace((number)))))
            //    //{
            //    //    Console.WriteLine();
            //    //    Console.WriteLine("Invalid List");
            //    //    continue;
            //    //}

            //    numbers.Add(Convert.ToInt32(number));
            //}

            //Console.WriteLine();
            //Console.WriteLine("The 3 smallest numbers in the List");
            //for (int i = 0; i > 3; i++)
            //{
            //    lowestNumbers.Add(i);
            //    //if (numbers.Contains(Int32.MinValue))
            //    //{
            //    //    lowestNumbers.Add(i);
            //    //}
            //}

            //Console.WriteLine();
            //foreach (var num in lowestNumbers)
            //{
            //    Console.WriteLine(num);
            //}
            //Console.WriteLine(formattedLowestNumbers);

            //Console.WriteLine();
            //Console.WriteLine(formattedNumbers);


            //string [] elements;
            //while (true)
            //{
            //    Console.Write("Enter a list of comma-separated numbers: ");
            //    string input = Console.ReadLine();

            //    if (!String.IsNullOrWhiteSpace(input))
            //    {
            //        elements = input.Split(',');
            //        if (elements.Length >= 5)
            //        {
            //            break;
            //        }

            //        Console.WriteLine("Invalid List");
            //    }
            //}

            //List<int> numbers = new List<int>();
            //foreach (var number in elements)
            //{
            //    numbers.Add(Convert.ToInt32(number));
            //}

            //List<int> smallests = new List<int>();

            //while (smallests.Count < 3)
            //{
            //    // Assume the first number is the smallest
            //    int min = numbers[0];

            //    foreach (var number in numbers)
            //    {
            //        if (number < min)
            //        {
            //            min = number;
            //        }
            //    }

            //    smallests.Add(min);

            //    numbers.Remove(min);
            //}

            //Console.WriteLine("The 3 smallest number aer: ");
            //foreach (var number in smallests)
            //{
            //    Console.WriteLine(number);
            //}

        }
    }
}

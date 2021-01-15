using System;
using System.Text;
using System.Collections.Generic;

namespace mosh_csharp_basic.working_with_text.exercise_with_working_with_text
{
    public class exercise_5
    {
        public void Ex5()
        {
            //5 - Write a program and ask the user to enter an English word.
            //    Count the number of vowels(a, e, o, u, i) in the word. 
            //    So, if the user enters "inadequate", the program should display 6 on the console.

            //Console.Write("Enter an english word: ");
            //string input = Console.ReadLine().ToLower();

            //List<char> letters = new List<char>();
            //foreach (var letter in input)
            //{
            //    letters.Add(letter);
            //}

            //List<int> numberOfVowels = new List<int>();
            //foreach (var letter in letters)
            //{
            //    if (letter == 'a' || letter == 'e' || letter == 'o' || letter == 'u' || letter == 'i')
            //    {
            //        numberOfVowels.Add(letter);
            //    }
            //}

            //Console.WriteLine();
            //Console.WriteLine("Number of vowels in the word: {0}", numberOfVowels.Count);

            //****Mosh's Answer**

            Console.Write("Enter a word: ");
            //Note the ToLower() here. This is used to count for both A and a.
            string input = Console.ReadLine().ToLower();

            List<char> vowels = new List<char>(new char[] { 'a', 'e', 'o', 'u', 'i' });
            int vowelsCount = 0;
            foreach (var character in input)
            {
                if (vowels.Contains(character))
                {
                    vowelsCount++;
                }
            }

            Console.WriteLine(vowelsCount);



        }
    }
}

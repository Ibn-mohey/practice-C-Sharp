using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mosh_csharp_basic.working_with_text.procedural_programming
{
    class ex7
    {
        /// <summary>
        /// Write a program and ask the user to enter an English word. Count the number of vowels 
        /// (a, e, o, u, i) in the word. So, if the user enters "inadequate", the program should display 
        /// 6 on the console. Make sure the program calculates the number of vowels irrespective of the 
        /// casing of the word (eg "Inadequate", "inadequate" and "INADEQUATE" all include 6 vowels).
        /// </summary>

        public void exercrise7()
        {
            Console.Write("Enter a word: ");
            //Note the ToLower() here. This is used to count for both A and a.
            string input = Console.ReadLine().ToLower();
            
            //List<char> vowels = new List<char>(new char[] { 'a', 'e', 'o', 'u', 'i' });
            //int vowelsCount = 0;

            //foreach (var character in input)
            //{
            //    if (vowels.Contains(character))
            //    {
            //        vowelsCount++;
            //    }
            //}

            //Console.WriteLine(vowelsCount);
            
            Console.WriteLine(CountVowels(input));
          
        }

        public int CountVowels(string word)
        {
            var vowels = new List<char>(new char[] { 'a', 'e', 'o', 'u', 'i' });
            var vowelsCount = 0;

            // Note the ToLower() here. This is used to count for both A and a. 
            foreach (var character in word.ToLower())
            {
                if (vowels.Contains(character))
                    vowelsCount++;
            }

            return vowelsCount;
        }
    }
}

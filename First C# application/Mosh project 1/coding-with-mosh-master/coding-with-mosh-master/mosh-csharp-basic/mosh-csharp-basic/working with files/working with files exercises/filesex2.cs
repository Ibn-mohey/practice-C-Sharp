using System;
using System.Collections.Generic;
using System.IO;

namespace mosh_csharp_basic.working_with_files.working_with_files_exercises
{
    class filesex2
    {
        //2- Write a program that reads a text file and displays the longest word in the file.

        public void GetFileEx2()
        {
            //Exercise 2
            
            List<string> myFileWordsList = new List<string>(File.ReadAllText(@"C:\Users\sonol\Downloads\_pcloud\_repositories\github\coding-with-mosh\mosh-csharp-basic\CSharpFileExercise.txt").Split(' '));

            List<string> longestWord = new List<string>();

            int letterTotal = 0;

            foreach (string word in myFileWordsList)
            {
                if (word.Length > letterTotal)
                {
                    longestWord.Clear();
                    longestWord.Add(word);


                    letterTotal = word.Length;

                }
            }
            Console.WriteLine(longestWord[0]);
        }
    }
}

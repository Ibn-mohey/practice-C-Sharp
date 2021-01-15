using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;

namespace mosh_csharp_basic.working_with_files.working_with_files_exercises
{
    class filesex1
    {
        //1- Write a program that reads a text file and displays the number of words.

        public void GetFileEx1()
        {
            string path = @"C:\Users\sonol\Downloads\_pcloud\_repositories\github\coding-with-mosh\mosh-csharp-basic\CSharpFileExercise.txt";

            string dataFromFile = File.ReadAllText(path);

            string[] words = dataFromFile.Split(new char[] { '"', ',', '.', '!', '?', ';', ':', ' ' });

            Console.WriteLine($"The total number of words in the File \"CSharpFileExercise\": {words.Length}");

        }
    }
}

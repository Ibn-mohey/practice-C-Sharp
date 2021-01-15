using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mosh_csharp_basic.working_with_text.procedural_programming
{
    class ex6
    {
        /// <summary>
        /// Write a program and ask the user to enter a few words separated by a space. Use the words to 
        /// create a variable name with PascalCase convention. For example, if the user types: 
        /// "number of students", display "NumberOfStudents". Make sure the program is not dependent on 
        /// the casing of the input. So if the input is "NUMBER OF STUDENTS", it should still display 
        /// "NumberOfStudents". If the user doesn't supply any words, display "Error".
        /// </summary>
        
        public void Exercrise6()
        {
            Console.Write("Enter a few words separted by a space e.g number of students: ");
            string input = Console.ReadLine();

            Console.WriteLine(GetVariableName(input));

            //string input = Console.ReadLine();

            //if (string.IsNullOrEmpty(input))
            //{
            //    Console.WriteLine("Error");
            //    return;
            //}

            //string variableName = "";
            //foreach (var word in input.Split(' '))
            //{
            //    string wordWithPascalCase = char.ToUpper(word[0]) + word.ToLower().Substring(1);
            //    variableName += wordWithPascalCase;
            //}

            //Console.WriteLine(variableName);
        }

        public string GetVariableName(string input)
        {
            if (String.IsNullOrWhiteSpace(input))
                return "";

            var variableName = "";
            foreach (var word in input.Split(' '))
            {
                var wordWithPascalCase = char.ToUpper(word[0]) + word.ToLower().Substring(1);
                variableName += wordWithPascalCase;
            }

            return variableName;
        }
    }
}

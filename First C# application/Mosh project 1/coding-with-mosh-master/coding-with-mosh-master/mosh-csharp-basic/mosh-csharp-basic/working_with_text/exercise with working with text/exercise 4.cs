using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;

namespace mosh_csharp_basic.working_with_text.exercise_with_working_with_text
{
    public class exercise_4
    {
        public void Ex4()
        {
            //4 - Write a program and ask the user to enter a few words separated by a space.
            //    Use the words to create a variable name with PascalCase. 
            //    For example, if the user types: "number of students", display "NumberOfStudents".
            //    Make sure that the program is not dependent on the input.
            //    So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".

            Console.Write("Enter a few words separted by a space e.g number of students: ");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Error");
                return;
            }

            string variableName = "";
            foreach (var word in input.Split(' '))
            {
                string wordWithPascalCase = char.ToUpper(word[0]) + word.ToLower().Substring(1);
                variableName += wordWithPascalCase;
            }

            Console.WriteLine(variableName);
            
        }
    }
}

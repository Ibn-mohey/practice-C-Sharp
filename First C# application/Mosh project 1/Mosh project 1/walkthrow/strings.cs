using System;
namespace Mosh_project_1.walkthrow
{
    public class strings
    {
        public static void Run()
        {
            Console.WriteLine("walkthrow 2 Run :)");

            var fullName = "dS DA ";
            Console.WriteLine("untrimmed '{0}'" , fullName);
            Console.WriteLine("trim: '{0}'",fullName.Trim());
            Console.WriteLine("Toupper: '{0}'",fullName.Trim().ToUpper());
            Console.WriteLine("___________");

            var spaceIndex = fullName.IndexOf(' ');
            var firstname = fullName.Substring(0, spaceIndex);
            var lastName = fullName.Substring(spaceIndex + 1);
            Console.WriteLine("first: " + firstname + " second: " + lastName);
            Console.WriteLine("___________");

            var names = fullName.Split();
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine("___________");

            var newName = fullName.Replace("dS", "real name ");
            Console.WriteLine(newName);
            Console.WriteLine("___________");

            if (String.IsNullOrEmpty(" ".Trim()))
            {
                Console.WriteLine("Invalid");
            }

            if (String.IsNullOrWhiteSpace(" "))
            {
                Console.WriteLine("Invalid");
            }
            Console.WriteLine("___________");
            /* deal with nums */

            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine(age);






            Console.WriteLine("___________");
        }
    }
}
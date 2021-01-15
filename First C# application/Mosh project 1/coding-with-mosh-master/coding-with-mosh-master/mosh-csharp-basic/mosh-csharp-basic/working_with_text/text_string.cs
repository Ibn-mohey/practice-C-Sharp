using System;

namespace mosh_csharp_basic.working_with_text
{
    class text_string
    {
        public void tString()
        {
            string fullName = "Peter Coker ";

            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("Trim: '{0}'", fullName.Trim().ToUpper()); //It returns a new string, remember string are immutable, you use two methods here.

            //The more specific to break a string is using indexof()
            //We can break the string as well here e.g

            int index = fullName.IndexOf(' ');
            string firstName = fullName.Substring(0, index);
            string lastName = fullName.Substring(index + 1);

            Console.WriteLine("First name:" + firstName);
            Console.WriteLine("Last name:" + lastName);

            //However the easy to break up a string is using split()
            //Easy way to break string using the split() e.g
            string[] names = fullName.Split(' ');
            Console.WriteLine("Split first name:" + names[0]);
            Console.WriteLine("Split last name:" + names[1]);

            Console.WriteLine(fullName.Replace("Peter", "Sonola")); //replace a string
            Console.WriteLine(fullName.Replace('o', 'O')); //replace a char

            if (String.IsNullOrEmpty(null)) //if the users enter a null
            {
                Console.WriteLine("Invalid");  //Output: Invalid
            }

            if (String.IsNullOrEmpty("")) //if the users enter an empty string
            {
                Console.WriteLine("Invalid"); //Output: Invalid
            }

            if (String.IsNullOrEmpty(" ")) //if the users enters a space
            {
                Console.WriteLine("Invalid"); //Output: It does not show Invalid
            }

            if (String.IsNullOrEmpty(" ".Trim())) //To fix this issue if the user enter a space we can uses this. However this too stressful
            {
                Console.WriteLine("Invalid"); //Output: Invalid
            }

            if (String.IsNullOrWhiteSpace("")) //With the IsNullOrWhiteSpace() we no longer have to use " ".Trim() if the users enters a space
            {
                Console.WriteLine("Invalid"); //Output: Invalid
            }


            string input = "25";
            byte age = Convert.ToByte(input); //We use byte instead of int as no one is older 255 years old

            Console.WriteLine(age);

            //Ever object in .Net has a ToString()
            float price = 29.95f;
            Console.WriteLine(price.ToString("C")); //We can format the string to output currency
            Console.WriteLine(price.ToString("C0")); //We can format the string to output a rounded number

            


        }
    }
}

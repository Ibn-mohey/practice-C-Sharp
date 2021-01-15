using System;

namespace mosh_csharp_basic.nonprimitive
{
    class CSharpString
    {
 
        

        public void CSharpStrings()
        {

            string firstName = "Peter";
            string lastName = "Coker";
            //var firstName = "Peter";

            string fullName = firstName + " " + lastName;

            string myFullName = string.Format("My name is {0} {1}", firstName, lastName);

            string[] names = new string[3] { "John", "Peter", "Sam" };

            string formattedNames = string.Join("+", names);

            Console.WriteLine(fullName);
            Console.WriteLine(formattedNames);

            string text = "Hi John\n Look into the follwing\\the";
            string texts = @"@Hi John
            Look into the following \folder";

            Console.WriteLine(text);
            Console.WriteLine(texts);
        }
    }
}

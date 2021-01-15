using System;
using System.Text; //Used for stringbuilder

namespace mosh_csharp_basic.working_with_text
{
    class stringbuilder
    {
        public void stringBuilder()
        {
            //StringBuilder builder = new StringBuilder();
            StringBuilder builder = new StringBuilder("Hello World");

            //builder.Append('-', 10);
            //builder.AppendLine();
            //builder.Append("Header");
            //builder.AppendLine();
            //builder.Append('-', 10);

            //builder.Replace('-', '+');

            //builder.Remove(0, 10);

            //builder.Insert(0, new string('-', 10));

            //If you look at the signature of the append method that returns a string builder
            //It's not a void method. It returns a string builder which means we can chain these
            //these append methods altogether and make our code e.g

            builder
                   .Append('-', 10)
                   .AppendLine()
                   .Append("Header")
                   .AppendLine()
                   .Append('-', 10)

            //This makes the code less noisy and more readable and the same is true for other methods here like
            //Replace(), Insert() all these return a string builder.

                   .Replace('-', '+')
                   .Remove(0, 10)
                   .Insert(0, new string('-', 10));


            Console.WriteLine(builder);

            Console.WriteLine("First Char: " + builder[10]);
        }

    }
}

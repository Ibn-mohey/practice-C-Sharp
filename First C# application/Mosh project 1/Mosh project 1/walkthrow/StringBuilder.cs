using System;
using System.Text;

namespace Mosh_project_1.walkthrow
{
    public class StringBuilders
    {
        public static void Run()
        {
            Console.WriteLine("string builder Run");

            //StringBuilder builders = new StringBuilder();
            //builders.Append();
            var builder = new System.Text.StringBuilder();
            builder
                .Append('d', 10)
                .AppendLine()
                .Append("header")
                .AppendLine()
                .Append('e', 10)
                .Replace('d', 'c')
                .Remove(0, 5)
                .Insert(0, new string('-', 3));

            Console.WriteLine(builder);
            Console.WriteLine(builder[2]);
        }

    }
}
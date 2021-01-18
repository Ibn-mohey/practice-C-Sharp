using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh_project_1.Advanced
{
    // to creat extention methof we need static class 
    public static class StringsssExtention
    {
        public static string Shorten(this string  str, int numberofwords)
        {
            if (numberofwords < 0)
                throw new ArgumentOutOfRangeException("NO should >= zero");

            if (numberofwords == 0)
                return "";
            var words = str.Split(' ');
            if (words.Length <= numberofwords)
                return str;
            else
            {
                return string.Join(" ", words.Take(numberofwords));
            }
        }
    }
    class AD09
    {
        public static void Run()
        {
            var post = "This is supposed to be a very long blog post blah blah blah...";
            var shortened = post.Shorten(5);
            Console.WriteLine(shortened);
        }
    }
}

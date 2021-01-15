using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh_project_1.walkthrow
{
    public class summarisingText
    {
        public static void Run()
        {
            Console.WriteLine("summarisingText Run");

            var sentence = "this is gonna be really long long long asdaksdlaks dkasd as;dja;sd; kasjd;asjd; jasd";
            var test = SummerizeText(sentence, 25);
            Console.WriteLine(test);
        }

        static string SummerizeText(string text ,int maxx = 20)
        {
            // const int maxx = 20;
            if (text.Length < maxx)
                return text;
            
            var words = text.Split(' ');
            var totalChars = 0;
            var summary = new List<string>();

            foreach (var word in words)
            {
                summary.Add(word);
                totalChars += word.Length + 1;
                if (totalChars > maxx) break;
            }

            return String.Join(" ", summary) + "...";
            // Console.WriteLine(String.Join(" ", summary) + "...");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revision._01.Basics_for_Beginners
{
    public class StringUtility
    {
        public static string SummerizeText(string sentence, int maxLength = 20)
        {
            if (sentence.Length < maxLength)
                return sentence;
            else
            {
                var words = sentence.Split(' ');
                var totalchar = 0;
                var summuryWords = new List<string>();
                foreach (var word in words)
                {
                    summuryWords.Add(word);
                    totalchar += word.Length + 1;
                    if (totalchar > maxLength)
                    {
                        break;
                    }
                }
                return String.Join(" ", summuryWords) + " .....";
            }
        }
    }
}
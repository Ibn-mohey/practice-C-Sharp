using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mosh_csharp_basic.working_with_text
{
    public class StringUtility
    {
        //We can have a second parameter here that specifices max Length
        //So instead of hard coding the number 20 we give this option to the caller of this
        //methd to specify the max length. This way we incearse re-usability so int max length
        //and we can give you the default value of 20 in case

        public static string SummerizeText(string text, int maxLength)
        {

            if (text.Length < maxLength)
            {
                return text;
            }

            string[] words = text.Split(' '); // We use the whitespace ' ' as a separator 


            int totalCharacters = 0;


            List<string> summaryWords = new List<string>();

            foreach (var word in words)
            {
                summaryWords.Add(word);

                totalCharacters += word.Length + 1; //We add + 1 because of the space after that word
                if (totalCharacters > maxLength)
                {
                    break;
                }
            }

            //string summary = String.Join(" ", summaryWords) + "..."; //It is clear the summerizeText method is return a text so we dont need to store this result in a variable


            return String.Join(" ", summaryWords) + "...";

        }

    }
}

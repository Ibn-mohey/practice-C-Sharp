using System;
using System.Collections.Generic;

namespace mosh_csharp_basic.working_with_text
{
    class summarising_text
    {
        public void summarising()
        {
            //Summarizing text you have seen on a lot of blogs on our home page

            string sentence = "This is going to be a really really really really long text.";
            const int maxLength = 20;

            if (sentence.Length < maxLength)
            {
                Console.WriteLine(sentence);
            }

            else
            {
                //why not to use the Substring(), because you may cut off a word as a result
                //We want the summary to look clean, we want to take into account the word boundaries
                //so the algorithm we are going to work on here is to count a number of words that roughly
                //fits around 20 characters.

                //sentence.Substring(0, maxLength);

                //****How to does this?
                //The first thing we want to do is to break this senetanets into words

                string[] words = sentence.Split(' '); // We use the whitespace ' ' as a separator 

                //if we roughtly get around 20 or go pass 20 that's a boundary where we need to cut
                //so we declare a variable 

                int totalCharacters = 0;

                //We need here is a list to dynamically store all these words that are going to be
                //part of the summary

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

                //Once we get out of this for each loop are some of the words list 
                //as all the words that need to go in the summary what we need to do
                //is to create a string and join all these words using whitespace

                //We use string.join() method

                string summary = String.Join(" ", summaryWords) + "...";
                Console.WriteLine(summary);

            }
            

        }
    }
}

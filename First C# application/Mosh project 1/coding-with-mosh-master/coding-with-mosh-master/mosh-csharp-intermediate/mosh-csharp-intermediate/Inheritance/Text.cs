using System;

namespace mosh_csharp_intermediate.Inheritance
{
    public class Text : PresentationObject
    {
        public int FontSize { get; set; }
        public string FountName { get; set; }

        public void AddHyperlink(string url)
        {
            Console.WriteLine("We added a link to " + url);
        }
    }
}
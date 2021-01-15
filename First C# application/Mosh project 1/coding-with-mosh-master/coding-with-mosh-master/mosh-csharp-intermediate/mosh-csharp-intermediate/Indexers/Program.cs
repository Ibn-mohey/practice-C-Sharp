using System;

namespace mosh_csharp_intermediate.Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpCookie cookie = new HttpCookie();
            cookie["name"] = "Peter";

            Console.WriteLine(cookie["name"]);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh_project_1.Intermediate
{
    public class PresentationObject
    {
        public int width { get; set; }
        public int height { get; set; }

        public void Copy()
        {
            Console.WriteLine("coppied");
        }


        public void Dublicate()
        {
            Console.WriteLine("dublicated");
        }

    }


    /*  */
    public class Text1 : PresentationObject
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }

        public void AddHyperlink(string url)
        {
            Console.WriteLine("ulr: " + url);
        }
    }

    /*     */





    /* program */
    class I17
    {
        public static void Run()
        {
            var text = new Text1();
            text.Copy();
        }

    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Mosh_project_1.Intermediate
{
    /*/*/
    public class Text : Shape
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }

    }

    /* */


    /*/*/
    class I23
    {

        public static void Run()
        {
            var texxt = new Text();
            Shape shapobj = texxt;
            // shape. will not be the same like texxt.
            texxt.Width = 200;
            shapobj.Width = 100;

            //Console.WriteLine(texxt.Width);

            // var reader = new StreamReader();

            Shape shape = new Text();
            // shape will be text type not shape and i cant get the shape prop
            var text = (Text) shape;


        }
    }
}

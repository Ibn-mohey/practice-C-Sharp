using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revision._01.Basics_for_Beginners
{
    internal class workingWithData
    {
        public static void demo()
        {
            var datetime = new DateTime(2015, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;
            Console.WriteLine(now.Hour + ":" + now.Minute);
        }
    }
}
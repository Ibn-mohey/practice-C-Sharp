using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revision._01.Basics_for_Beginners
{
    internal class person
    {
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine("my name is " + FirstName + " " + LastName);
        }
    }

    internal class StringClass
    {
        public static void staticStringMethod()
        {
            var firstname = "abdo";

            var lastname = "mohey";

            var name = string.Format("{0} {1}", firstname, lastname);

            Console.WriteLine(name);
            var names = new string[3] { "ahmed", "mohamed", "abdo" };
            var fromlist = string.Join(" separetor ", names);
            Console.WriteLine(fromlist);

            var bigText = @"this is
well formated text
to location
c:\folder1\forlder2";
            Console.WriteLine(bigText);
        }
    }

    internal class EnumClass
    {
        public enum ShippingMethods
        {
            meth1 = 1,
            meth2 = 2,
            meth3 = 3
        }

        public static void main()
        {
            var meth = ShippingMethods.meth1;
            Console.WriteLine((int)meth);

            var methID = 3;
            Console.WriteLine((ShippingMethods)methID);
            var method4 = "meth4";
            var ShippingMethod = (ShippingMethods)Enum.Parse(typeof(ShippingMethods), method4);
        }
    }
}
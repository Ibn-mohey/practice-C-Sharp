using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mosh_csharp_basic.Reference_Types_example
{
    class valuetype
    {
        //**Add to Main()
        //int number = 1;
        //Increment(number);
        //Console.WriteLine(number);

        //Vaule Types ****
        //int a = 10;
        //int b = a;
        //b++;
        //Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));


        public void Increment(int number)
        {
            number += 10;
            //Console.WriteLine(number);
        }

        //public static void MakeOld(ReferenceType referenceType)
        //{
        //    referenceType.Age += 10;
        //}
    }
}

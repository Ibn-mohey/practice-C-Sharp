using System;

namespace mosh_csharp_basic.primitive
{
    public class Operators
    {
        public void CSharpoperator()
        {
            //Addition and Division
            //var a = 10;
            //var b = 2;S

            //Console.WriteLine(a + b);
            //Console.WriteLine(a / b);
            //Console.WriteLine((float)a + (float)b);

            //Additional 
            //var a = 1;
            //int b = 2;
            //int c = 3;

            //Console.WriteLine(a + b * c); // + has a higher president over * result= 7
            ////Console.WriteLine((a+b) *c); //If you want a and b added together first and then multiple by c result = 9

            //comparison
            //var a = 1;
            //var b = 2;

            //Console.WriteLine(a > b);
            //Console.WriteLine(a == b);
            //Console.WriteLine(a != b);
            //Console.WriteLine(!(a != b));

            //Logical operator
            var a = 1;
            var b = 2;
            var c = 3;

            //Console.WriteLine(c > b && c > a);
            //Console.WriteLine(c > b && c == a);
            //Console.WriteLine(c > b || c == a);
            Console.WriteLine(!(c > b || c == a));

        }

    }
}

 using System;


namespace Mosh_project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Mohey");
            //byte number = 2;
            //int count = 10;
            //float totalPrice = 20.95f;
            //char character = 'a';
            //string firstName = "Mohey";

            //var number = 2;
            //var count = 10;
            //var totalPrice = 20.95f;
            //var character = 'a';
            //var firstName = "Mohey";


            //Console.WriteLine(count);
            //Console.WriteLine(totalPrice);
            //Console.WriteLine(character);
            //Console.WriteLine(firstName);
            //Console.WriteLine(number);
            //Console.WriteLine("{0} , {1}" , byte.MinValue , byte.MaxValue);

            //Console.WriteLine("{0} , {1}", float.MinValue, float.MaxValue);

            //const float Pi = 3.14f;

            //byte b = 1;
            //int i = b;
            //Console.WriteLine(i);

            //int i = 1;
            //byte b = (byte)i;
            //Console.WriteLine(b);

            //int i = 1000;
            //byte b = (byte)i;
            //Console.WriteLine(b);

            //var number = "1234";
            //// int i = (int)number; wont work as we need not to cast but to convert
            //int i = Convert.ToInt32(number);
            //Console.WriteLine(i);

            //try
            //{
            //    var number = "1234";
            //    // int i = (int)number; wont work as we need not to cast but to convert
            //    byte b = Convert.ToByte(number);
            //    Console.WriteLine(b);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Can't");
            //}



            //string s = "1";

            //int i = Convert.ToInt32(s);
            //int J = int.Parse(s);
            //Console.WriteLine(i);
            //Console.WriteLine(j);

            // classes
        } 

    /*  acccess class id */
        public  class Person
        {
            public string name;
    /*      access void name        */
            public void Intro() /* intro method ID by void and name of the method */
            /* void doesnt return and doesnt take parms */
            {
                Console.WriteLine("my name is " + name);
            }

        }

        /* */
        var person1 = new Person();

        person1.name = "mohey";
        person1.Intro();

        /* new */


        public class Calculator
        {
            public int Add(int a, int b)
            {
                return a + b;

            }

        }
    }
        
    
}
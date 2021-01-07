 using System;
 using System.Globalization;
 using System.Runtime.ExceptionServices;
 using Mosh_project_1.math;

 namespace Mosh_project_1
{

    public enum types
    {
        type1 = 10,
        type2 = 20,
        type3 = 30
    }

            


    
    class Program
    {
        static void Main(string[] args)
        {




            Console.WriteLine("__________");
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

            /*  create object */
            /* we need to get them a memory holder */
            //Person person1 = new Person();
            /* or */
            /*
            var person2 = new Person();
            person1.fname = "mohey";
            person1.lname = "MM";
            person1.Intro();

            // after use static we can access 
            Calculator calc = new Calculator();
            int result = calc.Add(1, 2);
            Console.WriteLine(result);
            // no need for var AAAA = new calculator 
            // only exist in memory once 
            /*
            int[] name = new int[3];
            name[0] = 1;
            Console.WriteLine(name[0]);
            Console.WriteLine(name[1]);
            Console.WriteLine(name[2]);

            var flags = new bool[3];
            flags[0] = true;
            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[2]);
            Console.WriteLine(flags[2]);

            var names = new string[3] { "sS", "b", "s" };
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);

            */
            /* strings */

            /*
            string FirstName = "abodo";
            string lastName = "mohey";
           
            string name1 = string.Format("{0} {1}", FirstName , lastName);
            Console.WriteLine(name1);
            /* same as */
            /*
            string name2 = String.Format("{0} {1}", FirstName, lastName);
            Console.WriteLine(name2);

            var tojoin = new String[3] {"ah","sfa", "boo"};
            string joined = string.Join(",", tojoin);
            Console.WriteLine(joined);
            
            
            String namesss = "ss";
            string namess = "nn";

            Console.WriteLine(namesss);

            Console.WriteLine("_______");

            /* Enums */
            /*
            var type11 = types.type3;
            Console.WriteLine((int)type11);

            Console.WriteLine(type11.ToString());

            Console.WriteLine(type11);

            /*
            var typeoff = 30;
            Console.WriteLine((types)typeoff);

            var ty = "type2";
            var typesss = (types)Enum.Parse(typeof(types), ty);

            Console.WriteLine("__________");

            string firstName2 = "John";
            string lastName2 = "Doe";
            string name3 = $"My full name is: {firstName2} {lastName2}";
            Console.WriteLine(name3);

            string myString = "Hello";
            Console.WriteLine(myString[0]);  // Outputs "H"

            string myString2 = "Hello";
            Console.WriteLine(myString2.IndexOf("e"));  // Outputs "1"

            Console.WriteLine("__________");

            // Full name
            string name4 = "John Doe";

            // Location of the letter D
            int charPos = name4.IndexOf("D");

            // Get last name
            string lastName4 = name4.Substring(charPos);


            // Print the result
            Console.WriteLine(lastName4);

            // or 
            Console.WriteLine(name4.Substring(name4.IndexOf("D")));
             */
            /*
            Console.WriteLine("__________");
            int time = 20;
            string result = (time < 18) ? "Good day." : "Good evening.";
            Console.WriteLine(result);
                */
            /*
            for (var i = 1; i <=10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                    
            }

            for (var i = 10; i >= 1; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            
            Console.WriteLine("________________");

            var name = "Abdo Mohey";
            for (var i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }
            Console.WriteLine("________________");
            foreach (var i in name)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("________________");
            var numbers = new int[] {1, 2, 3, 4,};
            foreach (var i in numbers)
            {
                Console.WriteLine(i);
            }

            */

            //for (var i = 10; i >= 1; i--)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //var i = 0;
            //while (i <= 10)
            //{
            //    if (i % 2 == 0)
            //        Console.WriteLine(i);
            //    i++;

            //}
            /*
            while (true)
            {
                Console.Write("test one ");
                var input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("u said " + input);
                    continue;
                }

                break;
            }

            */

            /*
            const int passwordlength = 10;
            var ramdomm = new Random();
            char[] buffer = new char[passwordlength];
            for (var i = 0; i < passwordlength; i++)
                buffer[i] =  (char)('a' + ramdomm.Next(0, 26));
            var password = new string(buffer);

            Console.WriteLine(password);
            */


            Console.Read()

























        }

    }

}
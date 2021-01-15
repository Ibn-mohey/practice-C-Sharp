using System;

namespace mosh_csharp_basic.primitive
{
    class Type_conversions
    {
        public void CSharpTypeConversions()
        {
            //non-compatbile type converision 
            try
            {
                string str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);

            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be convert to a byte");
            }

            //try
            //{
            //    var number = "1234";
            //    byte i = Convert.ToByte(number);
            //    Console.WriteLine(number);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("The number could not be convert to a byte");

            //}

            //var number = "1234";
            //byte i = Convert.ToByte(number);
            //Console.WriteLine(number);




            ////string number = "1234";
            //int i = Convert.ToInt32(number);
            //int i = int.Parse(number);
            //Console.WriteLine(i);

            //Explict type converision
            //int i = 1000;
            //byte b = (byte) i;

            //Console.WriteLine(b);

            //Implicit type converisoin
            //byte b = 1;
            //int i = b;

            //Console.WriteLine(i);
        }


    }
}

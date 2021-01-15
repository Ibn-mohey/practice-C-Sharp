using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mosh_csharp_basic.enums
{
    class enumexplained
    {
        public void EnumExplained()
        {
            //ENUMS*****************
            //ShippingMethod method = ShippingMethod.Express;
            //Console.WriteLine((int)method);

            //int methodId = 3;
            //Console.WriteLine((ShippingMethod)methodId);

            //Console.WriteLine(method.ToString()); //Console.WriteLine by default always call the ToString() method on any vaule to pass through it 
            //Console.WriteLine(method); //In case you're not convert using Console.WriteLine and what to explitly convert enum to a string than use the ToString() method

            //string methodName = "Enum";

            //ShippingMethod shippingMethod = (ShippingMethod) Enum.Parse(typeof(ShippingMethod), methodName);
        }
    }
}

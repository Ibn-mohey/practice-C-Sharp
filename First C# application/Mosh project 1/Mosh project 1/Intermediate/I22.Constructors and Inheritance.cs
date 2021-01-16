using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh_project_1.Intermediate
{

    public class Vehicle
    {
        private readonly string _regNum;

        // public Vehicle()
        // {
        //     Console.WriteLine("Vehicle is being initialized");
        // }

        public Vehicle(string regNum)
        {
            _regNum = regNum;
            Console.WriteLine("Vehicle is being initialized {0}", regNum);
        }
    }


    /*              */
    public class Car : Vehicle
    {
        public Car(string regNum)
            : base(regNum)
        {
            Console.WriteLine("car is being initialized {0}" , regNum);
        }

    }









    /* program */
    class I22
    {
        public static void Run()
        {

            var car = new Car("xyz");


        }
    }
}

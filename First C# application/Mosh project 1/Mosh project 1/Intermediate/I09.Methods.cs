using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh_project_1.Intermediate
{
    public class Point
    {
        public int X;
        public int Y;

        public Point(int x , int y)
        {
            this.X = x;
            this.Y = y;

        }

        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public void Move(Point newLocation)
        {
           // this.X = newLocation.X;
           // this.Y = newLocation.Y;
           // other way to do that 
           if (newLocation == null)
               throw new ArgumentException("newLocation"); // so i dont move and just stable the point 
           Move(newLocation.X , newLocation.Y);
        }
    }

    public class Calculator
    {
        public int Add(params int[] numberss)
        {
            var sum = 0;
            foreach (var i in numberss)
            {
                sum += i;
            }

            return sum;
        }
    }



    class I09
    {
        public static void Run()
        {
         //   int.Parse("abc");
         int numbera;
         var res = int.TryParse("abc", out numbera);
         Console.WriteLine(res);
        }
        /*               */
        public static void UseParams()
        {
            var calc = new Calculator();
            Console.WriteLine(calc.Add(1,2));
            Console.WriteLine(calc.Add(1,2,3));
            Console.WriteLine(calc.Add(1,2,3));
            // pass any number of parameter duo to the param key word 
            Console.WriteLine(calc.Add(new int[] {1 , 2, 3}));
        }
        /****************/
        public static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(null);
                Console.WriteLine("{0},{1}", point.X, point.Y);
                point.Move(42, 62);
                Console.WriteLine("{0},{1}", point.X, point.Y);
            }
            catch (Exception)
            {
                Console.WriteLine("unexpecter error");
            }

        }
    }
}

using System;

namespace mosh_csharp_basic.nonprimitive
{
    public class Calculator
    {
        //**Add to Main()
        
        //StructCalculator calculator = new StructCalculator();
        //int result = calculator.Add(1, 2);
        //Console.WriteLine("Calculator result is: " + result);

        //int result = Calculator.Add(1, 2); //If you were to add the static Modifier



        public int Add(int a, int b)
        {
            return a + b;
        }

        //public static int Add(int a, int b)
        //{
        //    return a + b;
        //}
    }
}

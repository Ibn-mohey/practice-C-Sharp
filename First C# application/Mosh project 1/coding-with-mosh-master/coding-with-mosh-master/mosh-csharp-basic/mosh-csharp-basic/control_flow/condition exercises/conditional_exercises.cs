using System;
using System.Runtime.InteropServices;
using System.Xml.Schema;

namespace mosh_csharp_basic.control_flow.condition_exercises
{
    class conditional_exercises
    {
        /// <summary>
        /// Write a program and ask the user to enter a number. The number should be between 1 to 10. If the user enters 
        /// a valid number, display "Valid" on the console. Otherwise, display "Invalid". (This logic is used a lot in 
        /// applications where values entered into input boxes need to be validated.)
        /// </summary>
        
        public void Exercise1()
        {
            string input;
            int number;

            Console.Write("Enter any number between 1 and 10: ");
            input = Console.ReadLine();
            number = Convert.ToInt32(input);

            Console.WriteLine(number >= 1 && number <= 10 ? "Vaild" : "Invalid");

            //Console.Write("Enter a number between 1 to 10: ");
            //var input = Console.ReadLine();
            //var number = Convert.ToInt32(input);
            //if (number >= 1 && number <= 10)
            //    Console.WriteLine("Valid");
            //else
            //    Console.WriteLine("Invalid");
        }


        /// <summary>
        /// Write a program which takes two numbers from the console and displays the maximum of the two.
        /// </summary>
      
        public void Exercise2()
        {
            int firstNumber, secondNumber, max;

            Console.Write("Enter first number: ");
            firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            secondNumber = Convert.ToInt32(Console.ReadLine());
            
            max = (firstNumber > secondNumber ? firstNumber: secondNumber);
            Console.WriteLine("Maximum number is " + max);

            //Console.Write("Enter a number: ");
            //var number1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter another number: ");
            //var number2 = Convert.ToInt32(Console.ReadLine());

            //var max = (number1 > number2) ? number1 : number2;
            //Console.WriteLine("Max is " + max);
        }

        /// <summary>
        /// Write a program and ask the user to enter the width and height of an image. Then tell if the image 
        /// is landscape or portrait.
        /// </summary>

        public void Exercise3()
        {
            double height, width;
            Enum orienatation;

            Console.Write("Enter a hight of image: ");
            height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter a width of image: ");
            width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(height > width ? "Image is portrait" : "Image is landscape");

            orienatation = (height > width ? ImageOrientation.Landscape: ImageOrientation.Portrait);

            //Console.Write("Image width: ");
            //var width = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Image height: ");
            //var height = Convert.ToInt32(Console.ReadLine());

            //var orientation = width > height ? ImageOrientation.Landscape : ImageOrientation.Portrait;
            //Console.WriteLine("Image orientation is " + orientation);


        }

        public enum ImageOrientation
        {
            Landscape,
            Portrait
        }

        /// <summary>
        /// Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors, 
        /// etc and focus purely on the logic. Write a program that asks the user to enter the speed limit. Once set, 
        /// the program asks for the speed of a car. If the user enters a value less than the speed limit, program should 
        /// display Ok on the console. If the value is above the speed limit, the program should calculate the number of 
        /// demerit points. For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on 
        /// the console. If the number of demerit points is above 12, the program should display License Suspended.
        /// </summary>

        public void Exercise4()
        {
            int speedLimit, Carspeed, demeritPoint;
            const int kmPerDemeritPoint = 5;

            Console.Write("Enter speed limit: ");
            speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter speed of car: ");
            Carspeed = Convert.ToInt32(Console.ReadLine());

            if (Carspeed <= speedLimit)
            {
                Console.WriteLine("Ok");
            }

            else
            {
                //demeritPoint = (Carspeed - speedLimit) / kmPerDemeritPoint;
                Console.WriteLine("Your car is speed {0}km/hr is above the speed limit of {1}km/hr \nNumber of Demerit points: {2}", Carspeed, speedLimit, demeritPoint = (Carspeed - speedLimit) / kmPerDemeritPoint);
                
                if (demeritPoint >= 12)
                {
                    Console.WriteLine("License Suspended");
                }
            }

            //Console.Write("What is the speed limit? ");
            //var speedLimit = Convert.ToInt32(Console.ReadLine());

            //Console.Write("What is the speed of this car? ");
            //var carSpeed = Convert.ToInt32(Console.ReadLine());

            //if (carSpeed < speedLimit)
            //    Console.WriteLine("Ok");
            //else
            //{
            //    const int kmPerDemeritPoint = 5;
            //    var demeritPoints = (carSpeed - speedLimit) / kmPerDemeritPoint;
            //    if (demeritPoints > 12)
            //        Console.WriteLine("License Suspended");
            //    else
            //        Console.WriteLine("Demerit points: " + demeritPoints);
            //}
        }
    }
}

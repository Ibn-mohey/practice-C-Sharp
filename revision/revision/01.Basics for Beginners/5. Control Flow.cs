using System;

namespace revision._01.Basics_for_Beginners
{
    internal class ConditionalStatements
    {
        public static void main(bool isGoldCustomer)
        {
            //// if, else if, else
            //int hour = 10;
            //if (hour > 0 && hour < 12)
            //    Console.WriteLine("morning");
            //else if (hour >= 12 && hour < 18)
            //    Console.WriteLine("after noon");
            //else
            //    Console.WriteLine("evening");
            //float price;
            //if (isGoldCustomer)
            //    price = 19.95f;
            //else
            //{
            //    price = 29.95f;
            //}
            //float price = (isGoldCustomer) ? 19.95f : 29.95f;
            //Console.WriteLine(price);
        }

        public static void demo2()
        {
            var season = Season.Autumn;
            switch (season)
            {
                case Season.Spring:
                    System.Console.WriteLine("it's Spring");
                    break;

                case Season.Summer:
                    System.Console.WriteLine("it's Summer");
                    break;

                case Season.Autumn:
                    System.Console.WriteLine("it's Autumn");
                    break;

                case Season.Winter:
                    System.Console.WriteLine("it's winter");
                    break;
            }
        }
    }

    internal class iterationStatments
    {
        public static void iterationdemo()
        {
            for (var i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    System.Console.WriteLine(i);
                }
            }

            for (int i = 10; i >= 1; i--)
            {
                if (i % 2 == 0)
                {
                    System.Console.WriteLine(i);
                }
            }
            var name = "mohey";

            for (int i = 0; i < name.Length; i++)
            {
                System.Console.WriteLine(name[i]);
            }
            System.Console.WriteLine("\n");
            foreach (var character in name)
            {
                System.Console.WriteLine(character);
            }
            System.Console.WriteLine("\n");

            var k = 0;
            while (k <= 10)
            {
                if (k % 2 == 0)
                {
                    System.Console.WriteLine(k);
                }
                k++;
            }

            while (true)
            {
                System.Console.Write("type your name: ");
                var input = System.Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                {
                    System.Console.WriteLine("@Echo: " + input);
                    continue;
                }
                break;
            }
        }
    }

    internal class RandomClass
    {
        public static void demo()
        {
            const int passwordLength = 10;

            var buffer = new char[passwordLength];

            var random = new Random();
            for (int i = 0; i < passwordLength; i++)
            {
                buffer[i] = (char)('a' + random.Next(0, 26));
            }
            var password = new string(buffer);
            Console.WriteLine(password);
        }
    }

    internal class Exercises
    {
        /* Write a program and ask the user to enter a number.The number should be between 1 to 10. If the user enters a valid number, display "Valid" on the console.Otherwise, display "Invalid". (This logic is used a lot in applications where values entered into input boxes need to be validated.) */

        public static void Exercise1()
        {
            Console.Write("Enter a number between 1 to 10: ");
            var input = Console.ReadLine();
            var number = Convert.ToInt32(input);
            if (number >= 1 && number <= 10)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Invalid");
        }

        /* Write a program which takes two numbers from the console and displays the maximum of the two.*/

        public static void Exercise2()
        {
            Console.Write("Enter a number: ");
            var number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter another number: ");
            var number2 = Convert.ToInt32(Console.ReadLine());

            var max = (number1 > number2) ? number1 : number2;
            Console.WriteLine("Max is " + max);
        }

        /* Write a program and ask the user to enter the width and height of an image.Then tell if the image is landscape or portrait.*/

        public static void Exercise3()
        {
            Console.Write("Image width: ");
            var width = Convert.ToInt32(Console.ReadLine());

            Console.Write("Image height: ");
            var height = Convert.ToInt32(Console.ReadLine());

            var orientation = width > height ? ImageOrientation.Landscape : ImageOrientation.Portrait;
            Console.WriteLine("Image orientation is " + orientation);
        }

        public enum ImageOrientation
        {
            Landscape,
            Portrait
        }

        /* Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic. Write a program that asks the user to enter the speed limit. Once set, the program asks for the speed of a car. If the user enters a value less than the speed limit, program should display Ok on the console. If the value is above the speed limit, the program should calculate the number of demerit points. For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console. If the number of demerit points is above 12, the program should display License Suspended.*/

        public static void Exercise4()
        {
            Console.Write("What is the speed limit? ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.Write("What is the speed of this car? ");
            var carSpeed = Convert.ToInt32(Console.ReadLine());

            if (carSpeed < speedLimit)
                Console.WriteLine("Ok");
            else
            {
                const int kmPerDemeritPoint = 5;
                var demeritPoints = (carSpeed - speedLimit) / kmPerDemeritPoint;
                if (demeritPoints > 12)
                    Console.WriteLine("License Suspended");
                else
                    Console.WriteLine("Demerit points: " + demeritPoints);
            }
        }
    }
}
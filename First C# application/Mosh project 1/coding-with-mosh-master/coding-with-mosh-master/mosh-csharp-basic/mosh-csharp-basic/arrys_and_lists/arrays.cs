using System;
using System.ComponentModel;

namespace mosh_csharp_basic.arrys_and_lists
{
    class arrays
    {
        public void ArraysDemo()
        {
            //int[] numbers = new int[] {3, 7, 9, 2, 14, 6};
            ////var numbers = new[] {3, 7, 9, 2, 14, 6};

            //// Length(): This method is used to find the legnth of the Array
            //Console.WriteLine("Length: " + numbers.Length);

            //// IndexOf(): This method is used to find the position in the Array
            //int index = Array.IndexOf(numbers, 9);

            ////var index = Array.IndexOf(numbers, 9); 
            //Console.WriteLine("Index of 9: " + index); //Output 9 is the 3rd element in the array

            //// Clear()
            //Array.Clear(numbers, 0, 2);

            //Console.WriteLine("Effect of Clear()");

            //foreach (var n in numbers)
            //{
            //    Console.WriteLine(n);
            //}

            //// Copy()
            //int[] another = new int[3];

            //Array.Copy(numbers, another, 3);

            //Console.WriteLine("Effect of copy()");
            //foreach (var n in another)
            //{
            //    Console.WriteLine(n);
            //}

            //// Sort()
            //Array.Sort(numbers);

            //Console.WriteLine("Effect of sort()");
            //foreach (var n in numbers)
            //{
            //    Console.WriteLine(n);
            //}

            //// Reverse()

            //Array.Reverse(numbers);

            //Console.WriteLine("Effect of reverse()");
            //foreach (var n in numbers)
            //{
            //    Console.WriteLine(n);
            //}

            ////Example of Mutlidimensional Array using a rectangle
            //int[,] myArray = new int[2, 3];

            //myArray[0, 0] = 1;
            //myArray[0, 1] = 2;
            //myArray[0, 2] = 3;

            //myArray[1, 0] = 4;
            //myArray[1, 1] = 5;
            //myArray[1, 2] = 6;

            //// int[,] myArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };

            //for (int i = 0; i < myArray.GetLength(0); i++) //Loops through the x axles of the rectangle
            //{
            //    for (int j = 0; j < myArray.GetLength(1); j++) //Loops through the y axles of the rectangle
            //    {
            //        Console.WriteLine(myArray[i, j]);
            //    }
            //}

            ////Example of Jagged Array using a reactangle
            //int[][] jagged = new int[2][]; //instead of , just add another square bracket e.g []

            //jagged[0] = new int[3];
            //jagged[1] = new int[5];

            //jagged[0][0] = 1;
            //jagged[0][1] = 2;
            //jagged[0][2] = 3;

            //jagged[1][0] = 4;
            //jagged[1][1] = 5;
            //jagged[1][2] = 6;
            //jagged[1][3] = 7;
            //jagged[1][4] = 8;

            //int[][] jagged2 = new int[2][];
            //jagged2[0] = new int[] { 1, 2, 3 };
            //jagged2[1] = new int[] { 4, 5, 6, 7, 8 };

            //int[][] jagged3 = new int[][]
            //{
            //    new int[] {1, 2, 3},
            //    new int[] { 4, 5, 6, 7, 8 }
            //};

            //for (int i = 0; i < jagged.Length; i++) //We want to get the length of the parent array
            //{
            //    for (int j = 0; j < jagged[i].Length; j++) // we are getting the length of the child array but now each child array can have differant length. we can not get the length for the whole second dimension, So we get it for each child array.
            //    {
            //        Console.WriteLine(jagged[i][j]);
            //    }
            //}


            //String array to store employee names and officals

            //OUTPUT
            //Mark
            //-------
            //Bachelor
            //Maske
            //Docatorate

            //Matt
            //--------
            //Bachelor

            //John
            //--------
            //Bachelor
            //Master

            string[] emplyeeNames = new string[3];
            emplyeeNames[0] = "Mark";
            emplyeeNames[1] = "Matt";
            emplyeeNames[2] = "John";

            string[][] jaggedArray = new string[3][]; //The first of these two "[][]" tells us the size of array

            jaggedArray[0] = new string[3];
            jaggedArray[1] = new string[1];
            jaggedArray[2] = new string[2];

            //initialize each string array

            //In the first element
            jaggedArray[0][0] = "Bachelors";
            jaggedArray[0][1] = "Masters";
            jaggedArray[0][2] = "Doctorate";

            //In the second element
            jaggedArray[1][0] = "Bachelors";
            
            //In the third element
            jaggedArray[2][0] = "Bachelors";
            jaggedArray[2][1] = "Masters";

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                string[] innerArray = jaggedArray[i];
                Console.WriteLine(emplyeeNames[i]);
                Console.WriteLine("--------");

                for (int j = 0; j < innerArray.Length; j++)
                {
                    Console.WriteLine(innerArray[j]);
                }

                Console.WriteLine();

            }



        }
    }
}

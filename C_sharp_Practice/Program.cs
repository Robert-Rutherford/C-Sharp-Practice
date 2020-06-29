using System;
using System.Linq;
namespace C_sharp_Practice
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            // Problem 1 tests
            double[] item1 = { 4, 2, 7, 1 };
            double[] item2 = { 20, 70, 40, 90 };
            double[] item3 = { 1, 2, 0 };
            double[][] testData = new double[][] { item1, item2, item3 };
            double[] largest1 = FindLargest(testData);
            Console.WriteLine("[{0}]", string.Join(", ", largest1));

            item1 = new double[] { -34, -54, -74 };
            item2 = new double[] { -32, -2, -65 };
            item3 = new double[] { -54, 7, -43 };
            testData = new double[][] { item1, item2, item3 };
            largest1 = FindLargest(testData);
            Console.WriteLine("[{0}]", string.Join(", ", largest1));

            item1 = new double[] { 0.4321, 0.7634, 0.652 };
            item2 = new double[] { 1.324, 9.32, 2.5423, 6.4314 };
            item3 = new double[] { 9, 3, 6, 3 };
            testData = new double[][] { item1, item2, item3 };
            largest1 = FindLargest(testData);
            Console.WriteLine("[{0}]", string.Join(", ", largest1));

            // Problem 2 tests
            Console.WriteLine("[{0}]", string.Join(", ", ArrayOfMultiples(7, 5)));
            Console.WriteLine("[{0}]", string.Join(", ", ArrayOfMultiples(12, 10)));
            Console.WriteLine("[{0}]", string.Join(", ", ArrayOfMultiples(17, 6)));
            

        }

        //problem #1
        // Find the Largest Numbers in a Group of Arrays
        // site: https://edabit.com/challenge/nermqxzovZbfFBC9X
        // Create a function that takes an array of arrays with numbers. Return a new
        //(single) array with the largest numbers of each.
        public static double[] FindLargest(double[][] values)
        {
            double[] returnList = new double[values.Length];
            int counter = 0;
            foreach(double[] numArray in values)
            {
                double largestNum = 0;
                int innerCount = 0;
                foreach(double number in numArray)
                {
                    if(innerCount == 0)
                    {
                        largestNum = number;
                        innerCount++;
                    }
                    if(largestNum < number)
                    {
                        largestNum = number;
                    }
                }
                returnList[counter] = largestNum;
                counter++;
            }
            return returnList;
        }


        //problem #2
        // Array of Multiples
        // site: https://edabit.com/challenge/2QvnWexKoLfcJkSsc
        // Create a function that takes two numbers as arguments (num, length)
        //and returns an array of multiples of num up to length.
        public static int[] ArrayOfMultiples(int num, int length)
        {
            int[] multiples = new int[length];
            for(int i = 1; i <= length; i++)
            {
                multiples[i - 1] = num * i;
            }
            return multiples;
        }





    }
}

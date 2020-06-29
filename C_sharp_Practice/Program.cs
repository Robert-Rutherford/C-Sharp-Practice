using System;
using System.Collections.Generic;
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
    }
}

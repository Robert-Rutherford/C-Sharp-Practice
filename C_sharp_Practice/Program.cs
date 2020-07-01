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
            Console.WriteLine(" ");
            Console.WriteLine("Problem 1");


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
            Console.WriteLine(" ");
            Console.WriteLine("Problem 2");

            Console.WriteLine("[{0}]", string.Join(", ", ArrayOfMultiples(7, 5)));
            Console.WriteLine("[{0}]", string.Join(", ", ArrayOfMultiples(12, 10)));
            Console.WriteLine("[{0}]", string.Join(", ", ArrayOfMultiples(17, 6)));

            // Problem 3 tests
            Console.WriteLine(" ");
            Console.WriteLine("Problem 3");

            Console.WriteLine(ReverseCase("Happy Birthday"));
            Console.WriteLine(ReverseCase("MANY THANKS"));
            Console.WriteLine(ReverseCase("sPoNtAnEoUs"));

            //Problem 4 test
            Console.WriteLine(" ");
            Console.WriteLine("Problem 4");

            Console.WriteLine(SortDescending(123));
            Console.WriteLine(SortDescending(2619805));
            Console.WriteLine(SortDescending(73065));

            //Problem 5 test
            Console.WriteLine(" ");
            Console.WriteLine("Problem 5");

            Console.WriteLine(HighLow("1 2 3 4 5"));
            Console.WriteLine(HighLow("1 2 -3 4 5"));
            Console.WriteLine(HighLow("1 9 3 4 -5"));
            Console.WriteLine(HighLow("13"));
            


            Console.WriteLine("End");

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


        //problem #3
        // Reverse the Case
        // site: https://edabit.com/challenge/99oN5igrbXddAjHEL
        // Given a string, create a function to reverse the case. All
        // lower-cased letters should be upper-cased, and vice versa.
        public static string ReverseCase(string str)
        {
            String newString = "";
            foreach(char letter in str)
            {
                if (Char.IsLetter(letter))
                {
                    if (Char.IsUpper(letter))
                    {
                        newString += Char.ToLower(letter);
                    }
                    else if (Char.IsLower(letter))
                    {
                        newString += Char.ToUpper(letter);
                    }
                    else
                    {
                        newString += letter;
                    }
                }
                else
                {
                    newString += letter;
                }
                
            }

            return newString;
        }


        //problem #4
        // Sort Numbers in Descending Order
        // site: https://edabit.com/challenge/N5G33s49LDXdhLdsT
        // Create a function that takes any nonnegative number as an argument
        // and return it with it's digits in descending order. Descending order
        // is when you sort from highest to lowest.
        public static int SortDescending(int num)
        {
            int newnum = 0;

            string strNum = num.ToString();
            char[] strArray = strNum.ToCharArray();
            int[] convertNums = new int[strArray.Length];
            for(int i = 0; i < strArray.Length; i++)
            {
                convertNums[i] = (int)Char.GetNumericValue(strArray[i]);
            }
            Array.Sort(convertNums);
            Array.Reverse(convertNums);
            newnum = Int32.Parse(String.Join("", convertNums));

            return newnum;
        }


        /* problem #5
        Return the Highest and Lowest Numbers
        site: https://edabit.com/challenge/zcuASzWmpFHpPtrbH
        Create a function that accepts a string of space separated numbers
        and returns the highest and lowest number (as a string).
        */
        public static string HighLow(string str)
        {
            string[] splitNums = str.Split(' ');
            int highest = 0;
            int lowest = 0;
            bool start = true;
            foreach(string num in splitNums)
            {
                int numInt = Int32.Parse(num);
                if (start)
                {
                    highest = numInt;
                    lowest = numInt;
                    start = false;
                }
                else
                {
                    if(numInt < lowest)
                    {
                        lowest = numInt;
                    }
                    if(numInt > highest)
                    {
                        highest = numInt;
                    }
                }
            }

            return highest + " " +lowest;
        }


    }
}


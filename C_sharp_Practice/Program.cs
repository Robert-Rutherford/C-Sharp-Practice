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

            //Problem 6 test
            Console.WriteLine(" ");
            Console.WriteLine("Problem 6");
            Console.WriteLine(IsStrangePair("ratio", "orator"));
            Console.WriteLine(IsStrangePair("sparkling", "groups"));
            Console.WriteLine(IsStrangePair("bush", "hubris"));
            Console.WriteLine(IsStrangePair("", ""));
            Console.WriteLine(IsStrangePair("", "bat"));

            //Problem 7 test
            Console.WriteLine(" ");
            Console.WriteLine("Problem 7");
            int[] arr = { 1, 2, 3, 4, 0, 0, -3, -2 };
            Console.WriteLine(MajorSum(arr));
            arr = new int[] { -4, -8, -12, -3, 4, 7, 1, 3, 0, 0, 0, 0 };
            Console.WriteLine(MajorSum(arr));
            arr = new int[] { 0, 0, 0, 0, 0, 1, 2, -3 };
            Console.WriteLine(MajorSum(arr));

            //Problem 8 test
            Console.WriteLine(" ");
            Console.WriteLine("Problem 8");
            Console.WriteLine(IsSmooth("Marta appreciated deep perpendicular right trapezoids"));
            Console.WriteLine(IsSmooth("Someone is outside the doorway"));
            Console.WriteLine(IsSmooth("She eats super righteously"));

            //Problem 9 test
            Console.WriteLine(" ");
            Console.WriteLine("Problem 9");
            Console.WriteLine(reversedBinaryInteger(10));
            Console.WriteLine(reversedBinaryInteger(12));
            Console.WriteLine(reversedBinaryInteger(25));
            Console.WriteLine(reversedBinaryInteger(45));

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

            return highest + " " + lowest;
        }

        /* problem #6
        Strange Pair
        site: https://edabit.com/challenge/8Sc582yHht2auBpCY
        A pair of strings form a strange pair if both of the following are true:
            The 1st string's first letter = 2nd string's last letter.
            The 1st string's last letter = 2nd string's first letter.
        Create a function that returns true if a pair of strings constitutes
        a strange pair, and false otherwise.
        */
        public static bool IsStrangePair(string str1, string str2)
        {
            if(str1.Length == 0 && str2.Length == 0)
            {
                return true;
            }
            if(str1.Length == 0 ^ str2.Length == 0)
            {
                return false;
            }

            if(str1[0] != str2[str2.Length - 1])
            {
                return false;
            }
            if(str1[str1.Length - 1] != str2[0])
            {
                return false;
            }
            return true;
        }

        /* problem #7
        The Major Sum
        site: https://edabit.com/challenge/8qkRcwf4ARtXpdwEW
        Create a function that takes an integer array and return the biggest
        between positive sum, negative sum, or 0s count. The major is
        understood as the greatest absolute.

        arr = {1,2,3,4,0,0,-3,-2}, the function has to return 10, because:

        Positive sum = 1+2+3+4 = 10
        Negative sum = (-3)+(-2) = -5
        0s count = 2 (there are two zeros in array)
        */

        public static int MajorSum(int[] arr)
        {
            int zeros = 0;
            int negativeSum = 0;
            int positiveSum = 0;

            foreach(int num in arr)
            {
                if(num == 0)
                {
                    zeros++;
                }
                else if(num < 0)
                {
                    negativeSum += num;
                }
                else if(num > 0)
                {
                    positiveSum += num;
                }
                else
                {
                    return 0;
                }
            }

            if(zeros > positiveSum && zeros > Math.Abs(negativeSum))
            {
                return zeros;
            }
            else if(positiveSum > zeros && positiveSum > Math.Abs(negativeSum))
            {
                return positiveSum;
            }
            else if(Math.Abs(negativeSum) > positiveSum && Math.Abs(negativeSum) > zeros)
            {
                return negativeSum;
            }
            else
            {
                return 0;
            }

            
        }

        /* problem #8
        Smooth Sentences
        site: https://edabit.com/challenge/SkY5Nw3rS7WvkQmFc
        Carlos is a huge fan of something he calls smooth sentences. A
        smooth sentence is one where the last letter of each word is identical to
        the first letter the following word.

        To illustrate, the following would be a smooth sentence:
        "Carlos swam masterfully."

        Since "Carlos" ends with an "s" and swam begins with an "s" and
        swam ends with an "m" and masterfully begins with an "m".
        */
        public static bool IsSmooth(string sentence)
        {
            string[] words = sentence.Split(' ');

            for(int i = 1; i < words.Length; i++)
            {
                int lastWordLength = words[i - 1].Length;
                char lastLetter = words[i - 1][lastWordLength - 1];
                char firstLetter = words[i][0];
                if(Char.ToLower(lastLetter) != Char.ToLower(firstLetter))
                {
                    return false;
                }
            }
            return true;
        }

        /* problem #9
        Reversing a Binary String
        site: https://edabit.com/challenge/TgtrCxdZxjaNBKvk3
        Write a function that takes an integer n, reverses the binary
        representation of that integer, and returns the new integer from the
        reversed binary.
        */
        public static int reversedBinaryInteger(int num)
        {
            string binaryConvert = Convert.ToString(num, 2);
            char[] charConvert = binaryConvert.ToCharArray();
            Array.Reverse(charConvert);
            string reverseBinary = new string(charConvert);
            int reverseNum = Convert.ToInt32(reverseBinary,2);
            return reverseNum;
        }

    }
}


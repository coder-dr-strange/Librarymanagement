using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Librarymanagement
{
    public class ArrayExamples
    {
        public int[] integers = { 11, 22, 33, 44, 55 };
        public void ArrayPrint()
        {
            /* Console.WriteLine("1. Write an array of integers and print them : " + integers[0] + "," + integers[1] +"," + integers[2] +"," + integers[3] + "," + integers[4]);
            int max = integers.Max();
            int min = integers.Min();
            Console.WriteLine("2. Given an array, find the maximum and minimum values:" + "Max value is "+ integers.Max() + " Min value is : " + integers.Min() );

            int sum = integers[0] + integers[1] + integers[2] + integers[3] + integers[4];
            Console.WriteLine("3. Calculate the sum of all elements in an array: " + sum);

            *int Sum = integers.Sum();
            Console.WriteLine("3. (Variation) Value of sum can be " + integers.Sum());
            Console.WriteLine($"3. (variation) Value of sum : {Sum}");

            double average = integers.Average();
            Console.WriteLine("4. Average of all " + integers.Average());

            int count = integers.Count();
            Console.WriteLine("5. count " +integers.Count());

            int Divisibleby11 = integers.Count( x => x % 11 == 0);
            Console.WriteLine("6.how many are divisble by 11 ; " + Divisibleby11);

            int Even = integers.Count(x => x % 2 == 0);
            Console.WriteLine("7. Even numbers : " + Even );

            int[] EvenValues = integers.Where(x => x % 2 == 0).ToArray(); //find them and store them
            // Console.WriteLine("8. Values of even numbers : " + EvenValues);
            int even = EvenValues.Length; //counted             [par isko method jese q nai likha??]
            Console.WriteLine("8. Evennumbers are : " + string.Join(",", EvenValues) );

            int Odd = integers.Count(x => x % 2 != 0);
            Console.WriteLine("9. Odd numbers : " + Odd);
             
            int[] OddValues = integers.Where(x => x % 2 != 0).ToArray(); //find and store them
            int odd = OddValues.Length; //counted
            Console.WriteLine("10. Odd numbers are : " + string.Join(",",OddValues));

             Array.Reverse(integers);
            Console.WriteLine("11. Reverse values are : " + string.Join(",", integers));  */

            int[,] max =
            {
                {6,23,21 },
                { 4,45,32},
                {69,11,87 }
            };
            int x = 32;
            bool found = true;

            foreach (int value in max)
            { if (x == 32)
                {
                    found = true;
                    break;
                }
                Console.WriteLine("Example 1 value of x " + found);

            }

            //Input: mat[][] = [[14, 34, 23, 95, 43, 28]], x = 55

            int[] mat = { 14, 34, 23, 95, 28 };
            int X = 55;
            bool notfound = false;
            foreach (int value in mat)
            {
                if (X != 55)
                {
                    notfound = false;
                    break;
                }
            }
            Console.WriteLine("Example 2 value of X " + notfound);

            // Input: MAT[][] = [[87, 9, 99], [101, 3, 111]], xx = 101

            int[,] MAT =
            { {87,9,99 },
                {101,3,111 }
            };
            int xx = 101;
            bool xxfound = true;
            foreach (int value in MAT)
            {
                if (xx == 101)
                { xxfound = true;
                    break;
                }
                Console.WriteLine("example 3 value of xx " + xxfound);
            }

            /* Input:
            N = 7
            Arr[] = { 1, 2, 3, 2, 3, 1, 3 }
            Output: 3
            Explaination: 3 occurs three times.*/

            int[] Arr = new int[7] { 1, 2, 3, 2, 3, 1, 3 };
           int[] repeatationof3 = Arr.Where(w => 3 == 0).ToArray();
            int rep3 = Arr.Length;
            Console.WriteLine(string.Join(","+Arr));

            int arr = 3;
            foreach (int value in Arr)
            {
                if (x == 3)
                {
                    
                    return;
                }
                Console.WriteLine($"Repeatatn of 3 is {rep3} times");
            }



        } 
    }
} 

using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Librarymanagement
{
    class ArrayEx2
    {
       public int[] array = new int[] { 3,6,5,6,4,7,8 };

        //to change an element in array 
        //writing logic in method
        public void changeelement(int[] e, int location, int value)
        {
            {
                for (int i = 0; i > e.Length; i++)
                {
                    if (i == location)
                    {
                        e[location] = value;
                    }
                }
            }
        }
       //creating method to print the created logic now
                
         public void printthis(int[]array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i] + ",");
            }
        }
            
        

        public void Printing()
        { 

            foreach (int value in array)
            {
                int x = 5;
                bool itispresent = true;

                if (x == 5)
                {
                    Console.WriteLine("Ex 1 " + itispresent);
                    
                }

                else
                {
                    Console.WriteLine("It is not present");
                    return;
                }
            }

            int[] ARR = new int[] { 1, 2, 3, 4, 5 };
            Array.Reverse(ARR);
            Console.WriteLine($"Value reversed  + {string.Join("," + ARR)}");

            /*foreach (int value in ARR)
            {
                for (int i = 0; i < ARR.Length; i++)
                { Array.Reverse(ARR); }
            }*/






        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Librarymanagement
{
    public class Generics<T>
    {
        public  T value1;
        public T value2;
        public T value3;

        public Generics(T value1,T value2,T value3)
        {
            value1 = value1;
            value2 = value2;
            value3 = value3;
 
        }
        public void ShowList()
        {
            Console.WriteLine($"All values are {value1},{value2},{value3}");
        }
        public void Showarray<T>(int[] arr)
        {
            Console.WriteLine("Values of array are ");
            for (int i = 0; i< arr.Length; i++)
            {
                Console.WriteLine($"{arr[i]}"); 
            }
        }

        public void SwapValues<T>(ref T a, ref T b)
        {
            T tingi = a;
            a = b;
            b = tingi;
            Console.WriteLine();
        }
    }
}

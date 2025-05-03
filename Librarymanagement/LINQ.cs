using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;
using System.Linq;

namespace Librarymanagement
{
    class LINQ
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        public void PRINT()                   //pehle value dalo fir uske linq dalo fr usko print method dalo 
        {
            var EvenNumbers = from num in numbers
                              where num % 2 == 0
                              select num;
            Console.WriteLine("EvenNumbers ");

            foreach (int n in EvenNumbers)
            {
                Console.Write(n);
            }

        }
    }
}


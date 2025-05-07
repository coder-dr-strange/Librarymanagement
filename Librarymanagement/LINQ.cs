using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;
using System.Linq;
using System.Net.Http.Headers;

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
            Console.Write("EvenNumbers : ");

            foreach (int n in EvenNumbers)
            {
                Console.Write(n);
            }
            Console.WriteLine("");
            Console.WriteLine("");

            var OddNumbers = from Num in numbers
                             where Num % 3 == 0
                             select Num;
            Console.Write("Divisible by 3 : ");
            foreach (int N in OddNumbers)
            {
                Console.Write(N);
            }
            Console.WriteLine("");

            var Greaterthan5 = from num in numbers
                               where num > 5
                               select num;
            Console.WriteLine("Greaterthan5 : ");
            foreach (int g in Greaterthan5)
            {
                Console.WriteLine(g);  
            }

            var twoconditions = from num in numbers
                                where num > 3
                                where num < 8
                                select num;
            Console.WriteLine("Between 3 to 8 : ");
            foreach (int t in twoconditions)
            {
                Console.WriteLine(t);
            }
            var Sorting = from num in numbers
                          orderby num descending
                          select num;
            Console.WriteLine("Descending sorting :");
            foreach (int s in Sorting)
            {
                Console.Write(s);
            }

            List<string> People = new List<string> {"papa","dada","nana","mummi","dadi","nani"};
            var Females = People.Where(P => P.EndsWith("i"));
            Console.WriteLine("");
            Console.WriteLine("Females via method: ");
            foreach (var p in Females)
            {
                Console.WriteLine(p);  
            }

            var Males = from p in People
                        let LastChar = p.ToLower()
                        where LastChar.EndsWith('a')
                        select p;
            Console.WriteLine("Males via let keyword : ");
            foreach (string p in Males)
            {
                Console.WriteLine(p);
            }

            List <string> Names = new List<string> { "pappu", "raju", "raamu", "bebo", "poonam" };
            var fourlettername = from string s in Names
                                 where s.Length == 4
                                 select s;
            Console.WriteLine($"Names " + Names[0] +"," + Names[1]+"," + Names[2] +"," + Names[3] +","+ Names[4]);
            
            Console.WriteLine("Four letter names are : ");

            int count = 0;
            int total= fourlettername.Count();
           foreach(string i in fourlettername)
            {
                Console.Write(i);
                count++;
                if (count < total)
                {
                    Console.Write(",");
                }
            }
            Console.WriteLine();



            int[] Sort = new int[]{ 22, 34, 66, 33, 78 };

             var Minus1 = from num in Sort
                          where num - 1 == 0
                          select num;
            Console.Write("Minus 1 values : ");
            Console.WriteLine("");
             
            for (int i = 0; i < Sort.Length; i++)
            {
                    Console.Write(Sort[i] - 1);
              if (i < Sort.Length-1)
                {
                    Console.Write(",");
                }
            }
            Console.WriteLine();
            Console.WriteLine("originial values were : ");

            for (int i =0; i < Sort.Length; i++)
            {
                Console.Write(Sort[i]);  
                if (i < Sort.Length-1)
                {
                    Console.Write(",");
                }
            }

        }
    }
}


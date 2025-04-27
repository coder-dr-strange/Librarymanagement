using System;
using System.Collections.Generic;
using System.Text;

namespace Librarymanagement
{
    public class StringExamples
    {
        public string name = "Chitrangda";
        
        public void Print()
        {
            Console.WriteLine("1. String alloted is - " +name);
            Console.WriteLine("2. Length is - " + name.Length);

            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine("3. Alplabets - " + name[i]);
            }

            Console.WriteLine("4. Change all a to o - " + name.Replace("a","o"));

            string remove = name.Remove(1, 1);
            Console.WriteLine("5. Remove h - " +remove );

            for (int j= 0; j < name.Length; j++)
            {

               // Array.Remove(name);
              //  Console.WriteLine("6. Remove all a - " + name[j]);
            }
        }

    }
}

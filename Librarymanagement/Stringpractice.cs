using System;
using System.Collections.Generic;
using System.Text;

namespace Librarymanagement
{
    public class Stringpractice
    {
        public string name = "Qwerty";

        public void alterations()

        {
            Console.WriteLine("OG "+name); 
            
             string replace = name.Replace("e", "P");
            Console.WriteLine("Changed " + replace);
            string lowercase = name.ToLower();
            Console.WriteLine("lowercase " + lowercase);
            string upper = name.ToUpper();
            Console.WriteLine("Uppercase " + upper);
            bool sdf = name.EndsWith("y");
            Console.WriteLine("Ends with y: " + sdf);
            bool ss = name.StartsWith("q");
            Console.WriteLine("starts with q " +ss);

            Console.ReadLine();

        } 
    }
}

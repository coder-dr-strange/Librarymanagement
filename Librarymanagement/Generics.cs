using System;
using System.Collections.Generic;
using System.Text;

namespace Librarymanagement
{
    public class Generics<T>
    {
       public  T value;

        public Generics(T value1,T value2,T value3)
        {
            value = value1;
        }
       public void ShowList()
        {
            Console.WriteLine($"First values are {value}");
        }
    }
}

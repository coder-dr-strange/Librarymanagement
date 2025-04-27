using System;
using System.Collections.Generic;
using System.Text;

namespace Librarymanagement
{
    abstract class AbstractAnimal
    {
        public abstract void Sleeps();
         //no body so non abstract method that will be implemented by subclasses
        
        public  void Eats()
        {
            Console.WriteLine("Abstract animal eats four times");
        }
    }
}

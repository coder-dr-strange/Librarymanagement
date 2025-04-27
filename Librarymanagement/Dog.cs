using System;
using System.Collections.Generic;
using System.Text;

namespace Librarymanagement
{
    public class Dog : Animal
    {
        public void Barks()
        {
            Console.WriteLine("Dog barks.");
        }
        public override void Talks()
        {
            Console.WriteLine("Dog talks.");
        }
    }
}

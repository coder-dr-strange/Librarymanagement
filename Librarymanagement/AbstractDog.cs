using System;
using System.Collections.Generic;
using System.Text;

namespace Librarymanagement
{
    class AbstractDog : AbstractAnimal
    {
       public override void Sleeps()
        {
            Console.WriteLine("Sleeps four hours");
        }
    }
}

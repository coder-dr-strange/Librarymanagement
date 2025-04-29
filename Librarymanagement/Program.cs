using System;
using System.Runtime.InteropServices;

namespace Librarymanagement
{
    class Program
    {
        static void Main(string[]args)
        {
            /*
             Book obj = new Book("Title","Author",true);
             Book.Total();

          Member obj1 = new Member("Pransh", 40,2,1);
              _ = new Member("Pooja", 43, 2,1);
            obj1.MemberCount(); */
            //  Console.ReadLine();
            // Console.WriteLine("Total books issued are:" + BooksIssued);
            //  Console.WriteLine("Remaining books are:" + TotalBooks);



            /* ArrayExamples obj = new ArrayExamples();
             obj.ArrayPrint();

             StringExamples Object = new StringExamples();
              Object.Print();

             Animal A = new Animal();
             A.Talks();
             Animal a = new Dog();  // upcasting
             a.Talks();  //static binding ??

             Dog d = new Dog();
             d.Talks();
             d.Barks();

             AbstractAnimal AA = new AbstractDog();
             AA.Sleeps();
             AA.Eats();

             IAnimal IA = new InDog();
             IA.EatGrass();
             IA.Dance();
             Console.WriteLine(); */

            var gen = new Generics<int>(10,20,30);
            var gen2 = new Generics<string>("dance", "play", "cry");
            var gen3 = new Generics<double>(2.2, 3.65, 9.59);
            gen.ShowList();
            gen2.ShowList();
            gen3.ShowList();
        }
    }
}

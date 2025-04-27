using System;
using System.Runtime.InteropServices;

namespace Librarymanagement
{
    class Program
    {
        static void Main(string[]args)
        {

            // Book obj = new Book("Title","Author",true);
            //  Book.Total();

            // Member obj1 = new Member("Pransh", 40,3);
            //  _ = new Member("Pooja", 43, 5);
            //  Console.ReadLine();
            // Console.WriteLine("Total books issued are:" + BooksIssued);
            //   Console.WriteLine("Remaining books are:" + TotalBooks);



            // ArrayExamples obj = new ArrayExamples();
            // obj.ArrayPrint();

            //  StringExamples Object = new StringExamples();
            // Object.Print();

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
        }
    }
}

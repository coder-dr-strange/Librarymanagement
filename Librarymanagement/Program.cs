using System;
using System.Runtime.InteropServices;

namespace Librarymanagement
{
    class Program
    {
        private static int[] array;

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



             /*    ArrayExamples obj = new ArrayExamples();
             obj.ArrayPrint(); */


            ArrayEx2 objectt = new ArrayEx2();
            objectt.Printing();
            //objectt.changeelement(array,4,44);

            LINQ linq= new LINQ();
            linq.PRINT();

           // structure.Typeit();



            /* StringExamples Object = new StringExamples();
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

            /* var gen = new Generics<int>(10,20,30);
            var gen2 = new Generics<string>("dance", "play", "cry");
            var gen3 = new Generics<double>(2.2, 3.65, 9.59);
            gen.ShowList();
            gen2.ShowList();
            gen3.ShowList();

            int[] array = new int[4] { 333, 333, 3, 333333 };
            gen.Showarray<int>(array);

            int num1 = 123; int num2 = 321;
            gen.SwapValues(ref num1, ref num2);
            Console.WriteLine($"Value of swap {num1}, {num2}");
            string str1 = "incomingse"; string str2 = "outgoingtak";
            gen2.SwapValues(ref str1, ref str2);
            Console.WriteLine($"Values of string swap {str1} , {str2}"); */



        }
    }
}

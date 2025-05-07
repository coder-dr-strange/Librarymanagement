using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Librarymanagement
{
    class Program
    {
        private static int[] array;

        static void Main(string[] args)
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


            /* ArrayEx2 objectt = new ArrayEx2();
            objectt.Printing();
            //objectt.changeelement(array,4,44);
            
            LINQ linq= new LINQ();
            linq.PRINT();*/

            /* Delegatez de = new Delegatez();
            de.Message("OTP is 1234");
            de.Email("OTP is 1234");
            de.Whatsapp("OTP is 1234");
            Notifier noti = new Notifier();
            noti.NotifyUser("ALERT",de.Message);
            noti.NotifyUser("ALERT", de.Email);
            noti.NotifyUser("ALERT", de.Whatsapp); */

            /* zShoppingCartModel cart = new zShoppingCartModel();
           // cart.GenerateTotal();
            Console.WriteLine("");
            cart.Items.Add(new zProductModel { ItemName = "Bucket", Price = 40.99M });
            cart.Items.Add(new zProductModel { ItemName = "Soap", Price = 20.99M });
            cart.Items.Add(new zProductModel { ItemName = "Chocolate", Price = 10.99M });
            //Console.WriteLine($"Total is Rs. {cart.GenerateTotal()}/-");
            Console.ReadLine(); */

            Stringpractice sp = new Stringpractice();
            sp.alterations();
        }


        /* Structuree st = new Structuree();
        st.method();
        st.i = 88; */

        /* Listproperty lp = new Listproperty();
        lp.data();*/

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


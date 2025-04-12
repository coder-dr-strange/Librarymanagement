using System;
using System.Runtime.InteropServices;

namespace Librarymanagement
{
    class Program
    {
        static void Main()
        {
            
            Book obj = new Book("Title","Author",true);
            Book.Total();

            Member obj1 = new Member("Pransh", 40,3);
            _ = new Member("Pooja", 43, 5);
           // Console.WriteLine("Total books issued are:" + BooksIssued);
             //   Console.WriteLine("Remaining books are:" + TotalBooks);
        }
    }
}

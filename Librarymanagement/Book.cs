using System;
using System.Collections.Generic;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Librarymanagement
{
    class Book
    {
        public void Details()
        {
            string Title;
            string Author;
            bool IsAvailable;

        }
        
        public static int Total()
        {
            // static method 

            int TotalBooks = 200;
            Console.WriteLine("Total books are- " +TotalBooks );
            return TotalBooks;
            
        }
        public Book(string Title,string Author,bool IsAvailable)
        {
            Title = "Title";
            Author = "Author";
            IsAvailable = true;
            Console.WriteLine("Title is: " + Title);
            Console.WriteLine("Author is: " + Author);
            Console.WriteLine("Books are available? " + IsAvailable);
        }

    }
}

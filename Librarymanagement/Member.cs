using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Librarymanagement
{
    class Member
    {
        //fields
        
        string name;
        int MembershipID;
        public int BooksIssued;

        //property
        public string MembershipDuration
        {
            get { return MembershipDuration; }      //get method
            set { MembershipDuration = "4 months"; }  //set method

        }

        public Member(string name, int MembershipID, int BooksIssued)
        {
            name = name;
            MembershipID = MembershipID;
            BooksIssued = BooksIssued;

            Console.WriteLine("Name of buyer: " + name);
            Console.WriteLine("ID is: " + MembershipID);
            Console.WriteLine("Books Issued : " + BooksIssued);

            if (BooksIssued >= 5)
            {
                Console.WriteLine("Maximum borrow limit reached for " + name);

            }
          //  int y = int TotalBooks- int BooksIssued;
          //  Console.WriteLine("Books remaining" +);

        }
           

        
    }
}

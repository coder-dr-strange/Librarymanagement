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
        public static int member;
        public void MemberCount ()
        {
            Console.WriteLine("member++");
        }

        private string _MembershipDuration;  //private backing field day2task

                                              //read only property day2task
        private string MembershipDuration
        {
            get { return MembershipDuration; }      //get method
            set { MembershipDuration = "4 months"; }  //set method

        }
                                               
                                           //added new properties datetime joineddate day2task
        public int DateTime { get; set; }
        public int JoinedDate { get; set; }
        public Member(string name, int MembershipID, int BooksIssued, int member)
        {
            name = name;
            MembershipID = MembershipID;
            BooksIssued = BooksIssued;
            BooksIssued++;
            member = member;
            member++;
            Console.WriteLine("Name of buyer: " + name);
            Console.WriteLine("ID is: " + MembershipID);
            Console.WriteLine("Books Issued : " + BooksIssued);
            if (BooksIssued >= 5)
            {
                Console.WriteLine("Maximum borrow limit reached for " + name);

            }
            Console.WriteLine("Members with issued books are " + member);
            Console.WriteLine("Total books issued are in library - " + BooksIssued);

            //  int y = int TotalBooks- int BooksIssued;
            //  Console.WriteLine("Books remaining" +);

        }



    }
}

using System;
using System.Collections.Generic;
using System.Text;
using static Librarymanagement.Delegatez;

namespace Librarymanagement
{
    public delegate void Notificationdelegate(string message); //creating a delegate

    class Delegatez
    {
        
        //creating various methods to call delegate parameter in methods
        public void Whatsapp(string message)
        {
            Console.WriteLine($"Wtsp notification alert:{message}");
        }
        public void Message(string message)
        {
            Console.WriteLine($"Msg notification alert{message}");
        }
        public void Email(string message)
        {
            Console.WriteLine($"Email notification alert {message}");
        }
    }
    //delegate method that will send notifications
 public class Notifier
    {
        public void NotifyUser(string message, Notificationdelegate NotifyMethod)
        {
            NotifyMethod(message);
        }
    }


}

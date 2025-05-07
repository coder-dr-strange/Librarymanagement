using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Librarymanagement
{
    class zShoppingCartModel
    {
        public delegate void MentionedDiscount(decimal Subtotal);

        public List<zProductModel> Items = new List<zProductModel>();
        public static void SubTotalAlert(decimal Subtotal)
        {
            Console.WriteLine($"Subtotal is {Subtotal}");
        }
        public decimal GenerateTotal(MentionedDiscount mentionedDiscount)
        {

            decimal Subtotal = Items.Sum(n => n.Price);
            mentionedDiscount (Subtotal);

        
        if (Subtotal > 100)
            {
                return Subtotal * 0.80M;   //discount given
                
            }
            else
                return Subtotal;
        }
    }
}

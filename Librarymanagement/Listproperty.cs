using System;
using System.Collections.Generic;
using System.Text;

namespace Librarymanagement
{
    class Listproperty
    {
        public int Id { get; set; }
        public string naam { get; set; }
        public int batch { get; set; }

        public void data()
        {
            List<Listproperty> Properties = new List<Listproperty>
            {
                new Listproperty { Id = 41, naam = "pooja", batch = 4 },
                new Listproperty { Id = 42, naam = "pinki", batch = 4 },
                new Listproperty { Id = 43, naam = "priya", batch = 4 },
            };
            Console.WriteLine($"Id Name Batch ");
                foreach (var i in Properties)
            {
                Console.WriteLine($"{i.Id} Miss {i.naam} {i.batch}th class");
            }
            Console.ReadLine();
        }
        
        /* public Listproperty(int Id, string naam, int batch) //constructor bana ke values alot krna
        {
            this.Id = Id;
            this.naam = naam;
            this.batch = batch;
        }*/


    }
}

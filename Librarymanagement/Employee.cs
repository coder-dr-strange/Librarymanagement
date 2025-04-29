using System;
using System.Collections.Generic;
using System.Text;

namespace Librarymanagement
{
    internal class Employee
    {
        public int ID { get; set; }
        public string Firstname {get;set;}
        public string Lastname {get; set;}
        public string Department { get; set; }
        public int Salary { get; set; }

    }
    internal static class DataManager
    {
        internal static List<Employee> GetData()
        {
            return new List<Employee>
            {
        // new Employee { ID = 20, Firstname = "Pooja", Lastname = "Ji", Department = "IMC", Salary = 20000 }
        
            };
            Console.WriteLine();
        }
    }
}

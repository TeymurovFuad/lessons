using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Customer
    {
        public string name; 
        public string surname; 
        public byte gender; 
        public string DocumentSerial { get; set; }
        public string DocumentNumber { get; set; }

        public Customer()
        {

        }

        public Customer(string n)
        {
            DocumentNumber = n;
            DocumentNumber = "";
        }

        public Customer(string s, string n)
        {
            DocumentNumber = n;
            DocumentSerial = s;
        }

        void CheckCustomerFromDb()
        {
            Console.WriteLine("Lorem ipsum");
        }
    }
}

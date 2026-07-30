using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo05.Simple_interfaces
{
    internal class Invoice : IPrintable
    {

        public int ID { get; set; }
        public decimal Amount { get; set; }

        public Invoice(int id , decimal amount) {
            ID = id;
            Amount = amount;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Invoice - Amount{Amount} - ID {ID}");
        }
    }
}

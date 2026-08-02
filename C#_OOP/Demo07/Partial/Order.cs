using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo07.Partial
{
    internal partial class Order
    {
       

        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }

        public Order(int id, string productName, decimal price)
        {
            Id = id;
            ProductName = productName;
            Price = price;
            OnCreated();
        }

        partial void OnCreated();
        

        override public string ToString()
        {
            return $"{Id} - {ProductName} - {Price}";
        }

    }
}

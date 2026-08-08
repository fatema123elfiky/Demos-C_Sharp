using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Demo01.GenericInterfaces
{
    internal class Product :  IComparable<Product> , ICloneable
    {
        public Product(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public Product()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        override public string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Price: {Price}";
        }

        public int CompareTo(Product? other)
        {
            return;
        }

        public object Clone()
        {
            return new Product();
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Demo01.Models
{
    internal class Product
    {

        public int Id { get; set; }
        public string? ProductName { get; set; }
        public int Stock {  get; set; }
        public decimal Price { get; set; }
    }
}

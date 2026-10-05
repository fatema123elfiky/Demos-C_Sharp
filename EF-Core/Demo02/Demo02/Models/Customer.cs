using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02.Models
{
    internal class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // first way without third table
        //public ICollection<Service> Services { get; set; } = new HashSet<Service>();
        // second way with third table 
        public ICollection<CustomerService> CustomerServices { get; set; } = new HashSet<CustomerService>();


        public Address Address { get; set; } = default!;
    }
}

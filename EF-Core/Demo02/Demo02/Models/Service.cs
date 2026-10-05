using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02.Models
{
    internal class Service
    {
        public int Id{ get; set; }
        public string Name{ get; set; }

        //public ICollection<Customer> Customers { get; set; } = new HashSet<Customer>();
        public ICollection<CustomerService> ServiceCustomers { get; set; } = new HashSet<CustomerService>();

    }
}

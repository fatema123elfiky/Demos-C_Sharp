using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02.Models
{
    [PrimaryKey(nameof(CustomerId),nameof(ServiceId))]
    internal class CustomerService
    {
        public int CustomerId{ get; set; }
        public Customer Customer { get; set; } = default!;
        public int ServiceId{ get; set; }
        public Service Service { get; set; } = default!;
    }
}

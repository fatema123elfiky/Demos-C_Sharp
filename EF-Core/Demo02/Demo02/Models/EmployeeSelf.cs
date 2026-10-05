using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02.Models
{
    internal class EmployeeSelf
    {
        [Key]
        public int EmpId { get; set; }

        public string Name { get; set; }

        public decimal Salary { get; set; }

        public string Address { get; set; }

        public DateTime HiringDate { get; set; }

        public int Age { get; set; }

        // self -referencing relationship

        [ForeignKey(nameof(Manager))]
        public int ManagerId{ get; set; }
        public EmployeeSelf? Manager { get; set; }
        // no need to make icollection of employees because it is not required in this case, but if you want to make it, you can do it like this:

    }
}

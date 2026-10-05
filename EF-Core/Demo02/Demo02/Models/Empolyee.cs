using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02.Models
{
    internal class Empolyee
    {
        public int EmpId { get; set; }

        public string Name { get; set; } 

        public decimal Salary { get; set; }

        public string Address { get; set; }

        public DateTime HiringDate { get; set; } 

        public int Age { get; set; }

        public Car Car { get; set; } = default!;

        [InverseProperty(nameof(CarOpt.Employee))]
        public CarOpt CarOpt { get; set; }

        [InverseProperty(nameof(EmployeeCar.Empolyee))]
        public EmployeeCar EmployeeCar { get; set; } = default!;
    }
}

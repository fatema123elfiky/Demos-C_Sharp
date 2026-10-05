using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02.Models
{
    internal class EmployeeCar
    {
        [Key]
        [ForeignKey(nameof(Empolyee))]
        public int EmployeeId { get; set; }

        [InverseProperty(nameof(Empolyee.EmployeeCar))]
        public Empolyee Empolyee { get; set; } = default!;
        
        [ForeignKey(nameof(Car))]
        public int CarId { get; set; }

        [InverseProperty(nameof(Car.EmployeeCar))]
        public Car Car { get; set; } = default!;
    }
}

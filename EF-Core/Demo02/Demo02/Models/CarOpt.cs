using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02.Models
{
    internal class CarOpt
    {

        [Key]
        public int CarId { get; set; }
        public string Model { get; set; } = string.Empty;
        
        [ForeignKey(nameof(Employee))]
        public int EmpId { get; set; }

        [InverseProperty(nameof(Empolyee.CarOpt))] // to mention which relationship
        public Empolyee Employee { get; set; } = default!;// one to one relationship

    }
}

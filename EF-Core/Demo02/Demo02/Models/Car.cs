using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02.Models
{
    // data annotation way
    [Table("Employees")]
    internal class Car
    {
        //data annotation way
        [Key]// mention primary key
        [ForeignKey(nameof(Employee))]// mention forgein key with the other table name
        public int EmpId{ get; set; }
        public int CarId { get; set; }
        public string Model { get; set; } = string.Empty;

        // that one and the other one in the other class repersent one -to -one relationship
        // but we will mention the mandatory side in both sides through we added at the top that is not new table 
        // it is  the rest of table and the foreign key will be in the table and mention the foreign key with which table
        
        public Empolyee Employee { get; set; } = default!;

        [InverseProperty(nameof(EmployeeCar.Car))]
        public EmployeeCar EmployeeCar { get; set; } = default!;
    }
}

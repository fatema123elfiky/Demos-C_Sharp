using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session03.Inheritance
{
    internal class Employee :Person
    {
        public decimal Salary { get; set; }

        public Employee(int id , string name , decimal salary) : base(id,name)
        { 
            Salary = salary;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo06.Obj_Copying
{
    internal class Employee : ICloneable
    {
        

        public int Id { get; set; }
        public string Name { get; set; }
        public Deptartment Dept { get; set; }

        public Employee(int id, string name, Deptartment dept)
        {
            Id = id;
            Name = name;
            Dept = dept;
        }

        public override string ToString()
        {
            return $"Id {Id} - Name {Name} - Dept {Dept}";
        }

        public object Clone()
        {
            return new Employee(Id, Name, (Deptartment)Dept.Clone());
        }
    }
}

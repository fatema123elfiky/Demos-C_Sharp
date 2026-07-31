using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo06.Obj_Copying
{
    internal class Deptartment : ICloneable
    {
       
        public string Name { get; set; }

        public Deptartment(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"{Name}";
        }

        public object Clone()
        {
            return new Deptartment(Name);
        }
    }
}

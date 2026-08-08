using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01.GenericConstraints.BaseClass
{
    internal class Cat : Animal
    {
        public Cat(string name) : base(name)
        {
        }
        public override string Speak()
        {
            return $"{Name} Meow"; 
        }
    }
}

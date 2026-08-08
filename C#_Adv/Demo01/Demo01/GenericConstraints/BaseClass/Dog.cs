using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01.GenericConstraints.BaseClass
{
    internal class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
        }
        public override string Speak()
        {
            return $"{Name} Woof";
        }
    }
}

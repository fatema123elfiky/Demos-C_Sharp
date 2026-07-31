using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo06.Abstract_Classes
{
    internal class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age)
        {
        }

        public override string MakeSound()
        {
            return "Woooof !";
        }

        public override string Move()
        {
            return "Move..Dog";
        }
    }
}

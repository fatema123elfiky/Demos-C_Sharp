using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04.Polymorphism.MethodHidding
{
    internal class Cat : Animal
    {
        public Cat(string name) : base(name) { }

        // just depending on ref and throw the parent implementation
        // in compile time
        public new void MakeSound()
        {
            Console.WriteLine($"{Name} meow meow");
        }


    }
}

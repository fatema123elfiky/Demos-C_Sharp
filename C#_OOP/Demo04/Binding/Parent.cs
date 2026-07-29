using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04.Binding
{
    internal class Parent
    {
        // new - compile time - based on ref - hidding - static binding
        public void Greet()
        {
            Console.WriteLine("Parent.Greet()");
        }

        // override - run time - based on obj - chaining - dynamic binding 
        public virtual void Introduce() {
            Console.WriteLine("Parent.Introduce()");
        }
    }
}

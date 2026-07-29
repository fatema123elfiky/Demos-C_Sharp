using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04.Binding
{
    internal class Child :Parent
    {
        public new void Greet()
        {
            Console.WriteLine("Child.Greet()");
        }

        public override void Introduce()
        {
            Console.WriteLine("Child.Introduce()");
        }

        public int Id { get; set; }

    }
}

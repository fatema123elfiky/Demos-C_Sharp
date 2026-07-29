using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Demo04.Polymorphism.MethodHidding
{
    internal class Dog : Animal
    {
        public Dog(string name) : base(name) { }

        //in runtime to choose between par & child
        // choose depending on obj
        public override void play()
        {
            Console.WriteLine($"{Name} runs in the park !");
        }


    }
}

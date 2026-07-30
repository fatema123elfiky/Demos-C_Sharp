using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo05
{
    public class Parent
    {
        public virtual int X { get; set; }

        public virtual void Display () {

            Console.WriteLine("This is parent class");
        }


    }


    public class Child : Parent
    {
        public sealed override int X { get => base.X; set => base.X = value; }

        public sealed override void Display()
        {
            Console.WriteLine("This is child class");
        }
    }

    public class GrandChild : Child
    {
        //override X; we could not but it has the behaviour
        // also for display method 
        // if class is sealed the process of inheritance will give u error !

    }
}

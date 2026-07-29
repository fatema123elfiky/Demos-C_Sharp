using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04.Polymorphism.MethodHidding
{
    internal class Animal
    {
        public string Name { get; set; }

        public Animal(string name) 
        {
            Name = name;
        }

        public void Eat() {

            Console.WriteLine($"{Name} is eating !");
        }

        public void MakeSound()
        {
            Console.WriteLine($"{Name} makes sound !");
        }

        public virtual void play()
        {
            Console.WriteLine($"{Name} plays !");
        } 
    }
}

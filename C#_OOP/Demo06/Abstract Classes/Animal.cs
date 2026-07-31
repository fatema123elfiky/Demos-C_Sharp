using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo06.Abstract_Classes
{
    internal abstract class Animal
    {
        protected Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }

        public abstract string MakeSound();

        public virtual string Move()=>"Move..";

        public string GetInfo() => $"{Age} - {Name}";



    }
}

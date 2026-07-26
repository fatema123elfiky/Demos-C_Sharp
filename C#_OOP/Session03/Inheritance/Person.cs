using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session03.Inheritance
{
    internal class Person
    {

        public int Id { get; set; }
        private string name;

        public string Name
        {
            get
            {
                return name;
            }

            set {
                if (!string.IsNullOrEmpty(value) && value.Length > )
                    name = value;
                else
                    name = "Invalid Name";
            }
        }

        public Person(int id , string name) { 
            Id = id;
            Name = name;
        }

        public override string ToString()=> $"ID - {Id} Name - {Name}";
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo06.Obj_Copying
{
    internal class Person
    {
      
        public int Age { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }

        public Person(int age, string name, Address address)
        {
            Age = age;
            Name = name;
            Address = address;
        }

        public override string ToString()
        {
            return $"Name : {Name} - Age : {Age} - Address {Address}";
        }

        public Person ShallowCopy()
        {
            return (Person)this.MemberwiseClone() ;
        }

        public Person DeepCopy()
        {
            return new Person(Age, Name, Address.Clone()) ;

        }
    }
}

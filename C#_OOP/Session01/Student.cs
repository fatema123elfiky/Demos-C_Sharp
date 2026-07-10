using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session01
{
    internal class Student
    {
        public int Age { get; set; }
        public string ? Name { get; set; }

        // constructor overloading and that depends on
        // number of datatypes and type of datatypes
        // order of datatypes
        public Student(int age , string name) {
            Age = age;
            Name = name;
            Console.WriteLine("CTOR01");
        }

        public Student() {
            Age = default;
            Name = default;
        }
        // chaining to avoid duplication
        public Student(string name):this(default, name) // chain is done first then the called constrcutor
        {
            /*Name = name;
            Age = default;*/
            Console.WriteLine("CTOR02");
        }

        public Student(int age): this(age,default)
        {
           /* Age = age;
            Name = default;*/
        }

        public void introduce() {

            Console.WriteLine($"Name : {Name}, Age : {Age}");
        
        }

        public static void Print()
        {
            Console.WriteLine("Hello");
        }

        public int calcYear() { 
        
            return DateTime.Now.Year - Age;
        }
    }
}

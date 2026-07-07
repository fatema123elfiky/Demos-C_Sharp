using Session06.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session06
{
    internal class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        // better to do enum as limited options and i know it!! whether facts or bussiness facts
        public Gender Gender { get; set; }

        public Branch Branch { get; set; }

        public override string ToString()
        {
            return $"Gender: {Gender} , Name: {Name} , ID : {Id} , Branch : {Branch}";
        }

        static public void Print()
        {
            Console.WriteLine("Hello route");
        }
    }
}

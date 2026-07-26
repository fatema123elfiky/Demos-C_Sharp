using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// correct as not in same namespace !!!
namespace Session03.Inheritance
{
    internal class Student : Person
    {
        public int Grade { get; set; }
        public Student (int id , string name , int grade ) :base (id,name)
        {
            Grade = grade;
        }

        public override string ToString()
        {
            return $"{ base.ToString() } - Grade : {Grade}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session03.Static
{
    internal class Student
    {
        //public string name;
        //public int id;
        //public static int counter = 0;

        public int id {  get; set; }
        public string name { get; set; }
        public static int counter { get; set; } =0;

        public Student(int id , string name) {

            counter++;
            this.id = id;
            this.name = name;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session03.Inheritance
{
    internal class Engine
    {
        public string Type { get; set; }

        public int HorseNumber {  get; set; }

        public Engine(string type , int num)
        {
            Type = type;
            HorseNumber = num;
        }

    }
}

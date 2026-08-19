using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02.Built_in_delegates
{
    internal class ActionExamples
    {
        public static void Greet()
        {
            Console.WriteLine("Hello , world");
        }

        public static void GreetPerson (string name)
        {
            Console.WriteLine($"Hello , {name} !");
        }

        public static void GreetwithAge(string name, int age) {

            Console.WriteLine($"Hello {name}, you are {age} old ");
        }
    }
}

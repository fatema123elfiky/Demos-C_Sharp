using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    internal class Pair <T1,T2,T3> where T1 : IComparable where T2 : IComparable where T3 : IComparable
    {
        public Pair(T1 first, T2 second, T3 third)
        {
            First = first;
            Second = second;
            Third = third;
        }

        public T1 First { get; set; }
        public T2 Second { get; set; }
        public T3 Third { get; set; }

        override public string ToString()
        {
            return $"({First}, {Second}, {Third})";
        }


    }
}

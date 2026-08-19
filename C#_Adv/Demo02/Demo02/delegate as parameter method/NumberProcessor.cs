using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02.delegate_as_parameter_method
{
    delegate bool FilterProcessor<T>(T item);
    delegate int TransformProcessor (int item);
    internal class NumberProcessor
    {
        // power of delegate & generics choose which filter for which type !
        public static List<T> Filter<T> (List<T> numbers , FilterProcessor<T> filtering)
        {
            List<T> filteredNumbers = new List<T>();
            foreach (var number in numbers)
            {
                if (filtering(number))
                {
                    filteredNumbers.Add(number);
                }
            }
            return filteredNumbers;
        }

        public static List<int> Transform (List<int> numbers , TransformProcessor transform)
        {
            List<int> filteredNumbers = new List<int>();
            foreach (var number in numbers)
            {
                filteredNumbers.Add(transform(number));
            }
            return filteredNumbers;
        }


        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        public static bool IsOdd(int number)
        {
            return number % 2 != 0;
        }

        public static bool FilterString(string str)
        {
            return str.Length > 4; 
        }

        public static int Square(int n)
        {
            return n * n;
        }

        public static int Double(int n)
        {
            return n * 2;
        }


    }
}

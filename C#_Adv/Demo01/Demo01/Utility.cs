using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    internal static class Utility
    {

        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        // if level on method so through paramters the generic could be predicted
        // but if level on class so the generic could not be predicted 

        // why we need method level generic? because maybe just for that method so it is not necessary to define it on class level
        // as clean code we should define the generic on method level if it is just for that method and not for the whole class

        public static void PrintArray<T>(T[] array)
        {
            
            Console.WriteLine($"[ {string.Join(',',array)} ]");
        }

        // constraint on datattype , accept any datatype that implements IComparable<T> interface
        public static T FindMax<T>( T [] values) where T : IComparable<T>
        {
            T max = values[0];

            for (int i = 0; i < values.Length; i++)
            {
                // values > max -> 1
                // values < max -> -1
                // values == max -> 0

                if (values[i].CompareTo(max) > 0)
                {
                    max = values[i];
                }
            }


            return max;
        } 
    }
}

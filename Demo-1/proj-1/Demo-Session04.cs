// not mandatory to use
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj_1
{
    internal class Demo_Session04
    {

        static void Main(string[] args)
        {
            #region Try Parse example

                Console.Write("Enter ur age: ");
                bool flag = int.TryParse(Console.ReadLine(), out int age);
                Console.WriteLine(flag);
                Console.WriteLine(age);

            #endregion

            #region ToString example
            double X = 10000000;
            DateTime date = DateTime.Now;

            Console.WriteLine(X.ToString("N1"));
            Console.WriteLine(X.ToString("0.00"));
            Console.WriteLine(X.ToString("C"));
            Console.WriteLine(date.ToString("t"));// short time
            Console.WriteLine(date.ToString("T"));// long time
            Console.WriteLine(date.ToString("d"));// short date
            Console.WriteLine(date.ToString("D"));// long date
            Console.WriteLine(date.ToString("dd-MM-yyyy"));// long date


            Console.WriteLine(X.ToString("C"));
            // same to
            Console.WriteLine($"{X:c}");

            // previous part is for builtin tostring and premade as override by c#
            // now for classes made by me , now we should override the tostring method 






            #endregion
        }
    }
}

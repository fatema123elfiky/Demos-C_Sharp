using System.Text;

namespace Session05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Strings 

            string str1 = new string("Ahmed");
            string str2 = "Ahmed";
            string str3 = string.Empty;
            string str4 = "";

            string first = "fatema";
            string second = "fatema";
            string third = "elfiky";

            Console.WriteLine(first.GetHashCode() + " " + second.GetHashCode() + " " + third.GetHashCode());


            // ways of concatenation

            string result = string.Concat("Ahmed", " ", "Fatema");// efficient way
            result = "Ahmed" + " " + "Fatema"; // worst way as creates three objects
            result = $"{first} {second}";
            result = string.Format("{0} {1}", first, second);

            string path1 = @"https:/drive.google.com/drive/folders/1_aLGI0_v-aLKbsswzgP1RRbzz2YUIJzQ";
            string path2 = "https://drive.google.com/drive/folders/1_aLGI0_v-aLKbsswzgP1RRbzz2YUIJzQ";



            // reference and addresses

            string s1 = "Hello world";
            string s2 = s1.ToUpper();


            // diff addresses and diff hashcodes
            Console.WriteLine(s1.GetHashCode());
            Console.WriteLine(s1);
            Console.WriteLine(s2.GetHashCode());
            Console.WriteLine(s2);

            string name1 = "Hello";
            string name2 = "Hello";
            string name3 = new string("Hello".ToCharArray());// different constructor from above two

            Console.WriteLine(name1.GetHashCode());//4551
            Console.WriteLine(name2.GetHashCode());//4551
            Console.WriteLine(name3.GetHashCode());//4551
            // same hashcode because same value , but different addresses because different constructor

            Console.WriteLine(object.ReferenceEquals(name1,name2));//true same add
            Console.WriteLine(object.ReferenceEquals(name1,name3));//false diff add


            // immutable

            string names = "Ahmed";
            Console.WriteLine(names.GetHashCode());
                            
            names = "fatema";
            Console.WriteLine(names.GetHashCode());// not same hashcode


            #endregion


            #region StringBuilder

            StringBuilder sb = new StringBuilder();
            sb.Append("Ahmed");
            Console.WriteLine(sb.GetHashCode());
            
            sb.Append(" Fatema");
            Console.WriteLine(sb.GetHashCode());// same hashcodes as no new objects which are not reachable

            // benchmarking between string and stringbuilder
            // performance comparison

            var watch = new System.Diagnostics.Stopwatch();
            string sRes = "";
            watch.Start();
            for (int i = 0; i < 10000; i++)
            {
                sRes += "a";
            }

            watch.Stop();

            Console.WriteLine(watch);


            var watch2 = new System.Diagnostics.Stopwatch();
            StringBuilder sbRes = new StringBuilder();
            watch2.Start();
            for (int i = 0; i < 10000; i++)
            {
                sbRes.Append("a");
            }

            watch2.Stop();

            Console.WriteLine(watch2);
            // it about memory management and performance, stringbuilder is more efficient than string concatenation


            ///// string formatting 
            string myname = "fatema";
            string age = "25";
            string salary = "10000";

            // not recommended way
            string res = myname + " " + age + " " + salary;
            Console.WriteLine(res);

            //best way
            res = $"{myname} {age} {salary}";
            Console.WriteLine(res);


            // composite formatting
            res = string.Format("{0} {1} {2}", myname, age, salary);
            Console.WriteLine(res);

            Console.WriteLine("{0} {1} {2}", myname, age, salary);



            #endregion


            #region switch case

            int day = 3;

            switch (day)
            {
                case 1:
                    Console.WriteLine("saturday");
                    break;
                case 2:
                    Console.WriteLine("sunday");
                    break;// not to make it or with the next one , so ww should break it
                case 3:
                    Console.WriteLine("monday");
                    break;
                default:
                    Console.WriteLine("Unknown");
                    break;


            }


            // new version of switch to be switch experssion , the prev called switch statement

            int month = 1;
            string season = month switch
            {
                1 or 12 or 2 => "Winter",
                3 or 4 or 5=> "Spring",  
                6 or 7 or 8 => "Summer",
                9 or 10 or 11 => "Autumn",
                _ => "Unknown"
            };

            Console.WriteLine(season);

            #endregion

            #region ternary operator

            int num1 = 10 , num2 = 20;
            int maxnum = num1 > num2 ? num1 : num2;



            #endregion
        }
    }
}

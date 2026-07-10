using Shared; // should be included as different namespace

namespace Session01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Class
            // 8 bytes
            Student s01 = new Student(20, "Ahmed");
            Console.WriteLine(s01.Age);
            Console.WriteLine(s01.Name);

            Console.WriteLine(s01.calcYear());
            s01.introduce();

            Student.Print();

            Student s02 = new Student(25, "Omar");

            Console.WriteLine(s01.GetHashCode());
            Console.WriteLine(s02.GetHashCode());
            Console.WriteLine(s01.Name);
            Console.WriteLine(s02.Name);


            s02 = s01;//both point to same obj

            Console.WriteLine(s01.GetHashCode());
            Console.WriteLine(s02.GetHashCode());
            Console.WriteLine(s01.Name);
            Console.WriteLine(s02.Name);

            s02.Name = "Kamal";

            Console.WriteLine(s01.Name);
            Console.WriteLine(s02.Name);

            // problem 
            Student s;
            s01.Name = "dssc ";
            // the problem the s is null , so accessing name in null , so nullreference exception

            #endregion

            #region Struct

            Point p01; // 8 bytes in stack allocated 
            p01 = new Point(); // just constructor selection here only
            // but in class memory in heap , constructor selection , put value


            p01 = new Point(10,20);
            Point p02 = new Point(100,200);

            Console.WriteLine(p01.X);//10
            Console.WriteLine(p02.X);//100

            p02 = p01;

            Console.WriteLine(p01.X);//10
            Console.WriteLine(p02.X);//10

            p02.X = 1000;

            Console.WriteLine(p01.X);//10
            Console.WriteLine(p02.X);//1000




            #endregion

            #region Class library
            Helper help = new Helper();

            Helper.Add(10, 20);
            #endregion

            #region access modifiers

            Helper h = new Helper();
            //h.x = 1;//could not be seen
            //h.y = 1;// could not be seen
            h.z = 1;// could be seen

            // so private -> only inside class
            // internal -> inside project only
            // public -> everywhere




            #endregion

        }
    }
}

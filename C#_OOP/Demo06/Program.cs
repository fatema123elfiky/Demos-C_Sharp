using Demo06.Abstract_Classes;
using Demo06.Obj_Copying;
using System.Text;

namespace Demo06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region copying ref - not real copying

            Person person01 = new Person(20,"ahmed",new Address("cairo","egypt"));
            Person person02 = person01;

            Console.WriteLine(person01);
            Console.WriteLine(person02);

            person02.Name = "omar";

            Console.WriteLine(person01);
            Console.WriteLine(person02);

            #endregion

            #region Shallow copy

            Person p01 = new Person(20, "ahmed", new Address("cairo", "egypt"));
            Person p02 = p01.ShallowCopy();

            Console.WriteLine(p01);
            Console.WriteLine(p02);

            person02.Name = "omar";

            Console.WriteLine(p01);// ahmed
            Console.WriteLine(p02);// omar 
            // as string is imutable new object is created when change happened

            Console.WriteLine("/////////////////////////////////");

            Console.WriteLine(p01);
            Console.WriteLine(p02);

            person02.Address.City= "Alex";

            Console.WriteLine(p01);// alex
            Console.WriteLine(p02);// alex 
            // as address is mutable and both point to same address and change occured in same address as it is mutable


            #endregion

            #region deep copy

            Person pp01 = new Person(20, "ahmed", new Address("cairo", "egypt"));
            Person pp02 = pp01.DeepCopy();

            Console.WriteLine(pp01);
            Console.WriteLine(pp02);

            person02.Name = "omar";

            Console.WriteLine(pp01);// ahmed
            Console.WriteLine(pp02);// omar 
            
            Console.WriteLine("/////////////////////////////////");

            Console.WriteLine(pp01);
            Console.WriteLine(pp02);

            person02.Address.City = "Alex";

            Console.WriteLine(pp01);// omar
            Console.WriteLine(pp02);// alex
            #endregion


            #region ICloneable interface

            #region Part 1

            int[] Nums1 = { 1, 2, 3, 4, 5, 6 };
            int[] Nums2 = (int[])Nums1.Clone();// .Clone () -> make shallow copy and proved down!

            Console.WriteLine(Nums1[0]);//1
            Console.WriteLine(Nums2[0]);//1

            Nums2[0] = 100;

            Console.WriteLine(Nums1[0]);//1
            Console.WriteLine(Nums2[0]);//100

            ////////////////////////

            string[] Names1 = { "Ahmed ", "Omar ", "Mohamed" ,"Aya"};
            string[]  Names2 = (string[] )Names1.Clone();

            Console.WriteLine(Names1[0]);//ahmed
            Console.WriteLine(Names2[0]);// ahmed

            Names2[0] = "Mona";


            Console.WriteLine(Names1[0]);//ahmed
            Console.WriteLine(Names2[0]);//mona


            StringBuilder [] names1 = { new StringBuilder("Ahmed "), new StringBuilder ("Aya" )};
            StringBuilder[] names2 = (StringBuilder [] )names1.Clone();

            Console.WriteLine(names1[0]);//ahmed
            Console.WriteLine(names2[0]);// ahmed

            names2[0].Append( " Omar");


            Console.WriteLine(names1[0]);//ahmed omar
            Console.WriteLine(names2[0]);//ahmed omar


            #endregion

            #region Part 2
            Employee emp1 = new Employee(10,"Ahmed",new Deptartment("HR"));
            Employee emp2 = (Employee)emp1.Clone();

            Console.WriteLine(emp1);
            Console.WriteLine(emp2);

            emp2.Name = "Omar";
            emp2.Dept.Name = "Sales";

            Console.WriteLine(emp1);
            Console.WriteLine(emp2);

            #endregion


            #endregion

            #region Abstract class

            Circle circle = new Circle(10);
            Rectangle rectangle = new Rectangle(10, 20);

            Console.WriteLine(circle.Area());
            Console.WriteLine(rectangle.Area());

            circle.Color = "Red";
            circle.Display();

            /// also ref of parent "abstract class" point object of child 
            /// we could  not make instance in abstract class only refernce as interface
            /// but the difference ==> in abstract class could contain constructor but interface no
            /// why ? as to avoid duplication through chaining of constructors with the classes that inherit and 
            /// implement that abstract class

            Shape c = new Circle(20);

            #endregion

        }
    }
}

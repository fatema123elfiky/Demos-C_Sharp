using Demo01.GenericInterfaces;
using Demo01.GenericConstraints.Simple;
using Demo01.GenericConstraints.BaseClass;
using Demo01.GenericConstraints.ConstructorConstraints;

namespace Demo01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Generics class

            #region EX01 & EX02

            Box<int> box1 = new Box<int>(10);
            box1.Value = 1;

            Box<string> box2 = new Box<string>("Hello");
            box2.Value = "World";

            Stack<int> stack = new Stack<int>(5);
            
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack.Count);
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Count);



            #endregion




            #endregion


            #region Generic methods

            #region EX01
            int x = 10;
            int y = 20;

            Utility.Swap<int>(ref x, ref y);
            Console.WriteLine(x);
            Console.WriteLine(y);


            #endregion


            #region EX02

            int [] arr = { 1, 2, 3, 4, 5 };
            Utility.PrintArray(arr);

            #endregion


            #region EX03

            int[] arr2 = { 1, 2, 10,3,-1, 4, 5 };

            Console.WriteLine (Utility.FindMax(arr2));


            #endregion

            #endregion

            #region multi generic

            Pair<int,string , double> pair = new Pair<int, string, double>(1,"hello",1.5);

            #endregion

            #region generic interface
            RepoProduct product = new RepoProduct();

            product.Add(new Product (1, "Product 1", 10.0 ));
            product.Add(new Product (2, "Product 2", 20.0 ));
            product.Add(new Product (3, "Product 3", 30.0 ));

            Console.WriteLine(product.GetById(1));

            #endregion


            #region generic constraints
            // unmanaged constraint -> only unmanaged types (int,float,double,struct)

            //// types of constraints 
            // primary constraint -> only one /// class,struct,notnull , unmanaged ,baseclass
            // secondary constraint -> many /// interface
            // constructor constraint --> only one /// parameterless constructor constraint

            Container<string> container = new Container<string>("d");
            AnimalShelter<Dog> dogShelter = new AnimalShelter<Dog>();

            Factory<Product> factory = new Factory<Product>();


            #endregion
        }
    }
}



using Demo07.Extensions;
using Demo07.Partial;
using Common07;

namespace Demo07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee { Id = 1, Name = "John Doe" };
            employee.Id = 1;
            employee.Display();


            Order order = new Order (1001, "Laptop" ,50000);
            Console.WriteLine(order);

            int X = 10;
            // X.
            Helper.IsEven(X);// instead of doing that and make it more readable we can use extension method
            X.IsEven();// MORE READABLE


            // different projects or solutions and i could add extension methods to the existing classes without modifying the original class code.
            Product product = new Product (10,"tea",10000);
            product.Print();

        }
    }
}

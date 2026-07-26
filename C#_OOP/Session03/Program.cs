using Session03.Static;

namespace Session03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Static

            Static.Student std1 = new Static.Student(10, "Ahmed");
            Static.Student std2 = new Static.Student(10, "Ahmed");
            Static.Student std3 = new Static.Student(10, "Ahmed");
            Static.Student std4 = new Static.Student(10, "Ahmed");

            Console.WriteLine(Static.Student.counter); 




            Counter.Increment();
            Counter.Increment();
            Counter.Increment();
            Console.WriteLine(Counter.Get());
            Counter.Reset();
            Console.WriteLine(Counter.Get());
            Counter.Increment();
            Counter.Increment();
            Counter.Increment();
            Counter.Decrement();
            Console.WriteLine(Counter.Get());


            Static.Product product = new Static.Product(10, "milk");
            Static.Product product2 = new Static.Product(10, "milk");
            Static.Product product3 = new Static.Product(10, "milk");
            Static.Product product4 = new Static.Product(10, "milk");

            Console.WriteLine(Static.Product.Counter);


            #endregion


            #region inheritance

            Inheritance.Student std = new Inheritance.Student(10, "ahmed", 100);

            Console.WriteLine(std);

            //

            Bank_03.BankAccount account = new Bank_03.BankAccount();
            //account.Id;
            //account.AccountNumber = 0;
            account.Balance = 0;

            //account.Pin = 0;
            //account.Name = string.Empty;
            //account.Password = string.Empty;

            #endregion
        }
    }
}

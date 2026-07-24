namespace Session02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region before encapsulation

            //BankAccount account = new BankAccount(1234,1000,"John Deo");

            // Console.WriteLine(account.AccountNumber);
            // the problem that i deal with the variables directly
            // if person A gave me ddl and contain that class and then he made some changes
            // and changed the name of variable that i use it directly outside class
            // which affects the outside environment and I changed , which is a big trouble as 
            // the out environment feels that change


            // Console.WriteLine(account.Id);
            // account.Id = 0;// that is prohibted , i just need to read id and prevent any updates and sets 
            // on it , so that is the second problem

            // i could not  prevent set and allow get

            // third problem is the validation problem 
            // as i could chnage in that way

            // account.Balance = -1;// i should put validation on variable itself




            #endregion

            #region setter and getter solution

            BankAccount account = new BankAccount(1234, 1000, "John Deo");

            Console.WriteLine(account.GetAccountNumber());

            #endregion

            #region Properties solution

            Console.WriteLine(account.Balance);// we call it as if it is var
            account.Balance = 78984;
            Console.WriteLine(account.Balance);


            #endregion


            #region Indexers

            //ToDoList toDoList = new ToDoList();

            ToDoList toDoList = new ToDoList(5);


            toDoList.AddTask("Buy T-shirts", 0);// gave error 
            // as the parameterless constructor
            // did not assign object to array which
            // carries only refernce of array with no object
            // so solve by chceking and validating in get and add
            // or make constructor 

            // now if we accessed out of range ?
            // so check it also in add,get



            Console.WriteLine(toDoList.GetTask(0));


            // use indexer as if class is array
            toDoList[0] = "buy phone";

            Console.WriteLine(toDoList[0]);

            Console.WriteLine(toDoList["buy phone"]);



            #endregion
        }
    }
}

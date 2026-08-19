using Demo02.BasicDelegate;
using Demo02.Built_in_delegates;
using Demo02.delegate_as_parameter_method;

namespace Demo02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Delegate

            int a = 10, b = 20;
            MathOperation<int> operation = Calculator.add;
            Console.WriteLine(operation.Invoke(a,b));
            operation= Calculator.subtract;
            Console.WriteLine(operation(a,b));

            #endregion

            #region delegate as paramter

            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> Return = NumberProcessor.Filter<int>(list, NumberProcessor.IsEven);

            foreach (int i in Return)
                Console.WriteLine(i);

            Return = NumberProcessor.Transform(list, NumberProcessor.Square);
            foreach (int i in Return)
                Console.WriteLine(i);

            List<string> list2 = new List<string>() { "Alice","Bob","Charlie","Mona"};
            List<string> res = NumberProcessor.Filter<string>(list2, NumberProcessor.FilterString);

            foreach (string i in res)
                Console.WriteLine(i);


            #endregion

            #region action 

            Action one = ActionExamples.Greet;
            one();

            Action<string> two = ActionExamples.GreetPerson;
            two("Bob");

            Action<string,int> three = ActionExamples.GreetwithAge  ;
            three("bob", 30);



            #endregion
        }
    }
}

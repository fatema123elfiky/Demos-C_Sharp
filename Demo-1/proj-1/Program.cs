namespace proj_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Try catch

            /*try
            {
                string s = null;
                s.ToUpper();

                int X = 0, Y = 10;
                int Z = Y/X;
            }
            catch(NullReferenceException ex ) // problem of  repeation
            {
                Console.WriteLine( ex.Message );

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }*/


            try
            {
                // db connection
                string s = null;
                s.ToUpper();

                int X = 0, Y = 10;
                int Z = Y / X;
            }
            catch (Exception e) { 
                Console.WriteLine(e.Message);
            }

            finally
            {
                // close db connection
                // that region will be implemented after the finish of try if no error
                // or after catch if there is an error
                // as catch stops the rest of program if there is an error but finally will continue the rest of the program
            }

            /*
             Actually, the code does continue after catch unless:
            the program crashes completely
            you use throw
            you use return
            environment terminates execution
             */




            /*
             If there were no catch, the exception 
            would usually terminate the program after finally.
            and if there is catch the code continues normally
             */


            try
            {
                string s = null;
                s.ToUpper();
            }
            finally
            {
                Console.WriteLine("finally");
            }




            Console.WriteLine("hello");

            Console.WriteLine("Welcome batata");
            int w = 1, u = 2, g;
            Console.WriteLine(u / w);

            #endregion

        }
    }
}

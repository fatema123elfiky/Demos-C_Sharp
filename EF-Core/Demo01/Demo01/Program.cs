namespace Demo01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            using(BazarDbContext bazarDbContext = new BazarDbContext())
            {

            }

            // for scope main is opend otherwise closed
            using BazarDbContext bazarDbContext2 = new BazarDbContext();



            // to close connection
            //bazarDbContext.Dispose();
        }
    }
}

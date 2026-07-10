namespace Shared
{
    public class Helper // take care to be public to be seen
    {

        private int x;
        internal int y;
        public int z;


        public Helper()
        {
            x = 20;// seen here
            y = 20;// seen here
            z = 20;// seen here
        }
        
        static public int Add(int x , int y)
        {
            return x + y;
        }

        static public int Mul(int x, int y)
        {
            return x * y;
        }

    }
}

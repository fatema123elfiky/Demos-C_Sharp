

namespace Shared
{
    internal class test
    {
       public test()
        {
            Helper h = new Helper();
            //h.x = 1;//could not be seen
            h.y = 1;// could be seen
            h.z = 1;// could be seen
        }
       
    }
}

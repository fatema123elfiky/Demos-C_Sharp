using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo05.Advanced_Interfaces
{
    internal class Document : ICloudStorage, ILocalStorage
    {
        // we could not name conflict , so make it explicitly
        //public void save()
        //{
        //    throw new NotImplementedException();
        //}
        void ICloudStorage.save()
        {
            Console.WriteLine("Store file in cloud");
        }

        void ILocalStorage.save()
        {
            Console.WriteLine("Store file in local");
        }
    }
}

using Bank_03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Session03
{
    internal class TestAccount : BankAccount
    {
        public TestAccount() {
           
            //Pin = 10;  // private protected - inherit : private protected used private 
            Name = string.Empty; //  protected - inherit : protected used private  

        }

    }
}

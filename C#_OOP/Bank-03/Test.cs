using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Bank_03
{
    internal class Test
    {
        public Test()
        {
            BankAccount account = new BankAccount();
            //account.Id;
            account.AccountNumber = 0;
            account.Balance = 0;

            //account.Pin = 0;
            //account.Name = string.Empty;
            account.Password = string.Empty;
        }

        
    }
}

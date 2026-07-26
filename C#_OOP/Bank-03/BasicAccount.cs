using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_03
{
    internal class BasicAccount: BankAccount
    {

        public BasicAccount() 
        {
            //Id = 0; could not inherit private

            AccountNumber = 0; // internal - inherit : internal used internal
            Balance = 0; // public - inherit : public used public

            Pin = 10;  // private protected - inherit : private protected used private 
            Name = string.Empty; //  protected - inherit : protected used private  
            
            //--> diff that protected could be inherited outside project , but private no

            Password = string.Empty;  // internal protected - inherit : internal protected used internal
            // internal protected could be inherited outside project

        }
    }
}

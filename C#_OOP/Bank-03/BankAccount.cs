using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_03
{
    public class BankAccount
    {
        private int Id {  get; set; }
        
        internal int AccountNumber { get; set; }

        public decimal Balance { get; set; }

        // no inheritance
        private protected int Pin {  get; set; } // private

        protected string Name { get; set; } // private

        internal protected string Password { get; set; } // internal

        public BankAccount()
        {
            Id = 10;
            AccountNumber = 0;
            Balance = 0;

            Pin = 0;
            Name = string.Empty;
            Password = string.Empty;
        }
    }
}

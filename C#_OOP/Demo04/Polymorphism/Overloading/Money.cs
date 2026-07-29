using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04.Polymorphism.Overloading
{
    internal class Money
    {

        public double Amount { get; set; }
        public string Currency {  get; set; }

        public Money(double amount , string currency) 
        {
            Amount = amount;
            Currency = currency;
        }

        public static Money operator +(Money a , Money b)
        {
            if (a == null || b == null || a.Currency != b.Currency)
                throw new InvalidOperationException("Invalid inputs");
            return new Money(a.Amount+b.Amount, a.Currency);
        }

        public override string ToString()
        {
            return $"{Amount} {Currency}";
        }
    }
}

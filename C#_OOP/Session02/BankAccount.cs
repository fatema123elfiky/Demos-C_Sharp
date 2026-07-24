

namespace Session02
{
    internal class BankAccount
    {
        // fields
        private int AccountNumber;
        private decimal _balance;//let us apply property on Balance // b small for var and B capital for properties
        private string _name;
        private int Id;

        // encapsulation

        #region Setter & getter
        // setter , getter
        public int GetAccountNumber()
        {
            return AccountNumber;
        }

        public void SetAccountNumber(int AccountNumber)
        {
            this.AccountNumber = AccountNumber;
        }

        // using encapsulation using setters and getters
        // solved six problems validation , outer env , set and get control
        // if we do not want the set make it private , could it be use private ?
        // yes if we need to apply validation on the passed value through constructors


        #endregion

        #region Properties

        // properties // better for readability
        // full property
        public decimal Balance
        {
            get { return _balance; }
           /*private*/ set { 
                if(value > 0)
                    _balance = value;
            }
        }


        // we could control set , get , we could add validation , outer env no effect

        // automatic property
        public string Name { get; private set; }
        public int Age { get; set; }
        // computed attribute
        public int YearOfBirth { get { return DateTime.Now.Year - Age; } }

        // make it better

        public int Year => DateTime.Now.Year - Age;// faster

        public string Address { get; init; }// for constructor only

        #endregion


        public BankAccount(int AccountNumber, decimal Balance, string Name)
        {
            this.AccountNumber = AccountNumber;
            this.Balance = Balance;
            this.Name = Name;
        }



    }
}

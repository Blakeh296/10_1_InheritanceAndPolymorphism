using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Demo
{
    class SavingsAccount
    {
        // Fields
        private string _accountNumber;
        private decimal _interestRate;
        private decimal _balance;
        private string _maturityDate;

        // Constructor
        public SavingsAccount()
        {
            _accountNumber = "";
            _interestRate = 0;
            _balance = 0;
            _maturityDate = "";
        }

        // Account Number Property
        public string AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }

        // Interest Rate Property
        public decimal InterestRate
        {
            get { return _interestRate; }
            set { _interestRate = value; }
        }

        // Balance Property
        public decimal Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }

        // Maturity Date Property
        public string MaturityDate
        {
            get { return _maturityDate; }
            set { _maturityDate = value; }
        }
    }
}

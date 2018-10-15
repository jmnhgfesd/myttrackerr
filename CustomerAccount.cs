using System;
using System.Collections.Generic;
using System.Text;

namespace MyTracker
{
    enum TypeOfBankCompanys
    {
        Chase,
        Amex
    }
    class CustomerAccount
    {
        public string UserName { get; set; }
        public TypeOfBankCompanys AccountBankCompany { get; set; }
        public decimal Balance { get; private set; }

        public CustomerAccount()
        {

        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }
    }
}

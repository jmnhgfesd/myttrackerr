using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyTracker
{
    class MainFrame
    {
        //store customer's credit card account name that customer submitted
        //private List<string> usernames;
        private static List<CustomerAccount> newCustomerAccounts = new List<CustomerAccount>();

        public static CustomerAccount CreateAccount(string userName, TypeOfBankCompanys accountBankCompany = TypeOfBankCompanys.Amex, decimal initalMoney = 0)
        {
            if (string.IsNullOrEmpty(userName))
            {
                throw new ArgumentNullException("userName", "A username is required!");
            }

            var customerAccount = new CustomerAccount
            {
                UserName = userName,
                AccountBankCompany = accountBankCompany
            };

            if (initalMoney > 0)
            {
                customerAccount.Deposit(initalMoney);
            }
            newCustomerAccounts.Add(customerAccount);
            return customerAccount;
        }

        public static IEnumerable<CustomerAccount> GetAllCustomerAccounts()
        {
            return newCustomerAccounts;
        }

        /* 
        //default constructor
        public MainFrame()
        {
            usernames = new List<string>();
        }

        //method for user to add credit card accounts
        public void AddMyAccount(string userName)
        {
            usernames.Add(userName);
        } */



    }
}

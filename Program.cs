using System;


namespace MyTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to MyTracker app");
            while (true)
            {
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Create an account");
                //Console.WriteLine("9. Show all my accounts");
                var option = Console.ReadLine();
                switch (option)
                {
                    case "0":
                        return;
                    case "1":
                        try
                        {
                            Console.Write("Username: ");
                            var userName = Console.ReadLine();
                            var accountBankCompanys = Enum.GetNames(typeof(TypeOfBankCompanys));
                            for (var i = 0; i < accountBankCompanys.Length; i++)
                            {
                                Console.WriteLine($"{i + 1}. {accountBankCompanys[i]}");
                            }
                            Console.Write("Bank Company Name: ");
                            var accountBankCompanysOption = Convert.ToInt32(Console.ReadLine());
                            var accountBankCompany = (TypeOfBankCompanys)Enum.Parse(typeof(TypeOfBankCompanys), accountBankCompanys[accountBankCompanysOption - 1]);
                            var amount = Convert.ToDecimal(Console.ReadLine());


                        }
                        catch
                        {
                            Console.WriteLine("Please try again.");
                        }
                        break;
                        //case "9":
                        //PrintAllAccounts;

                }

            }


            //constructor; creating new instance of the class, MainFrame


        }



        // create high, low, average of balances of customer's transaction
        // BalanceStatistics stats = book.ComputeStatistics();
    }
}

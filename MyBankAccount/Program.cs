using System;

namespace MyBankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var account_1 = new BankAccount("Péter", 5000);
            Console.WriteLine($"Account {account_1.Number} was created for {account_1.Owner} with {account_1.Balance}$ initial balance.");
            var account_2 = new BankAccount("Béla", 5000);
            Console.WriteLine($"Account {account_2.Number} was created for {account_2.Owner} with {account_2.Balance}$ initial balance.");

            account_1.MakeWithdrawal(120, DateTime.Now, "DVD");
            Console.WriteLine(account_1.Balance);

            account_1.MakeDeposit(130, DateTime.Now, "BlueRay");
            Console.WriteLine($"{account_1.Owner} {account_1.Balance}");

            Console.WriteLine(account_1.GetAccountHistory());
                
        }
    }
}

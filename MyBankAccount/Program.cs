using BankAccountLibrary;
using System;
using Humanizer;

namespace MyBankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(232500000.ToWords());
            


            var account_1 = new BankAccount("Péter", 5000);
           
 
            account_1.MakeWithdrawal(120, DateTime.Now, "kurva");
            account_1.MakeWithdrawal(10, DateTime.Now, "Whisky");
            account_1.MakeWithdrawal(12, DateTime.Now, "Gin");
            account_1.MakeWithdrawal(1, DateTime.Now, "Vodka");
            account_1.MakeWithdrawal(1200, DateTime.Now, "luxus kurva");
            account_1.MakeWithdrawal(2, DateTime.Now, "Rum");
            account_1.MakeDeposit(3000, DateTime.Now, "Fizu");
            account_1.MakeWithdrawal(5, DateTime.Now, "Wine");
            account_1.MakeWithdrawal(21, DateTime.Now, "Beer");
            
            try
            {
                account_1.MakeWithdrawal(750, DateTime.Now, "Attempt to overdraw");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Exception caught trying to overdraw");
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine(account_1.GetAccountHistory());
            Console.WriteLine();
            Console.WriteLine($"User name:\t {account_1.Owner}\nActual balance:\t {account_1.Balance} $");



        }
    }
}

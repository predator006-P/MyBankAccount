using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountLibrary
{
    public class BankAccount
    {
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance 
        { 
            get
            {
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
                }
                return balance;
            }
        }
        private static int accountNumberSeed = 1234567890;
        private List<Transactions> allTransactions = new List<Transactions>();


        public BankAccount(string name, decimal initialBalance)
        {
            this.Owner = name;

            MakeDeposit(initialBalance, DateTime.Now, "Initial balance");

            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
        }


        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            var report = new StringBuilder();
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            var deposit = new Transactions(amount, date, note);
            allTransactions.Add(deposit);
            report.AppendLine($"{deposit.Date.ToShortDateString()}\t{deposit.Amount}\t{deposit.Notes}");
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            var report = new StringBuilder();
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }
            var withdrawal = new Transactions(-amount, date, note);
            allTransactions.Add(withdrawal);
            report.AppendLine($"{withdrawal.Date.ToShortDateString()}\t{withdrawal.Amount}\t{withdrawal.Notes}");
        }

        public string GetAccountHistory()
        {
            var report = new StringBuilder();
            report.AppendLine("Date\t\tAmount\tNote");
            foreach (var item in allTransactions)
            {
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{item.Notes}");
            }
            return report.ToString();
        }

    }
}

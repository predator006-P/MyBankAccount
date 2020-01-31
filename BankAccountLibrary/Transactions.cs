using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountLibrary
{
    public class Transactions
    {
        public decimal Amount { get; }
        public DateTime Date { get; }
        public string Notes { get; }

        public Transactions(decimal amount, DateTime date, string note)
        {
            this.Amount = amount;
            this.Date = date;
            this.Notes = note;
        }
    }
}

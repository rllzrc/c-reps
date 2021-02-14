using System;

// to be able to accept deposits + withdrawals correctly -> will act as a journal of every transaction for an account -> this class will be a simple type to represent transactions => doesn't have any major responsibilities, just a few props

namespace MoneyBagBankBank {
  public class Transaction {
    public decimal Amount { get; }
    public DateTime Date { get; }
    public string Notes { get; }

    public Transaction (decimal amount, DateTime date, string note) {
      this.Amount = amount;
      this.Date = date; 
      this.Notes = note;
    }
  }
}
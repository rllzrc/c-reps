using System;
using System.Collections.Generic;
using System.Text;

namespace MoneyBagBank {
  public class BankAccount {
    // properties 
    // these are the "form fields"
    public string Number { get; }
    public string Owner { get; set; }
    public decimal Balance { 
      // to make it more dynamic, change origina get to behave more like a method 
      get {
        decimal balance = 0;
        foreach (var item in allTransactions) {
          balance += item.Amount;
        }
        return balance;
      } 
    }

    // only used within the BankAccount class
    private static int accountNumberSeed = 1234567890;

    private List<Transaction> allTransactions = new List<Transaction>();

    // constructor to make the bank account
    // think: this is the form 
    public BankAccount(string name, decimal initialBalance) {
      this.Owner = name;
      // the deposit of the initial balance will be run with the make deposit method 
      MakeDeposit(initialBalance, DateTime.Now, "Initial Balance");
      // this.Balance = initialBalance;
      this.Number = accountNumberSeed.ToString();
      accountNumberSeed += 1;
    }

    // methods 
    public void MakeDeposit(decimal amount, DateTime date, string note) {
      if (amount <= 0) {
        throw new ArgumentOutOfRangeException(nameof(amount), "Excuuuse me! Amount of deposit must be positive.");
      }
      var deposit = new Transaction(amount, date, note);
      allTransactions.Add(deposit);
    }
    
    public void MakeWithdrawal(decimal amount, DateTime date, string note) {
      if (amount <= 0) {
        throw new ArgumentOutOfRangeException(nameof(amount), "Ayy, moneybag isn't on nega-energy vibes. Amount of withdrawal must be positive.");
      }
      if (Balance - amount < 0) {
        throw new InvalidOperationException("Bummer! Not sufficient funds for this withdrawal. Let's do some creative viz + manifest it!");
      }
      var withdrawal = new Transaction(-amount, date, note);
      allTransactions.Add(withdrawal);
    }

    public string GetAccountHistory() {
      // from system builder
      var report = new StringBuilder();
      // report headers
      report.AppendLine("Date\t\tAmount\tNote");
      foreach(var item in allTransactions) {
        // report rows
        report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{item.Notes}");
      }
      return report.ToString;
    }
  }
}
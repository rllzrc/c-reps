using System;
using System.Collections.Generic;

// to provide a logical way to structure the codebase -> this app is v small so all the code will reside in this one namespace
namespace MoneyBagBankBank {
  // the class Bank Account -> this declaration also defines the state + behavior of the class
    public class BankAccount {
    // these are the "form fields" aka properties -> data/elements (can have additional code to enforce type validation + other rules)
    public string Number { get; }
    public string Owner { get; set; }
    // to sum up all the values within all transactions => this computation enumerates all transactions and provides the sum as the current balance
    public decimal Balance { get {
      decimal balance = 0;
      foreach(var item in allTransactions) {
        balance += item.Amount;
      }
      return balance;
      }
    }
    // not the best way to create an account number per say, but since this app is tiny this will suffice to generate a unique number for each account created => can only be accessed by code inside the BankAccount class -> implementation to generate numbers must remain private -> static = shared by all of the BankAccount objects (the value of a non-static variable is unique to each instance of the BankAccount object)
    private static int accountNumberSeed = 1234567890;
    // pulling data from Transactions class into a list of objects to extract out later
    private List<Transaction> allTransactions = new List<Transaction>();

    // to open a new account -> create a new object from the BankAccount class to define, assign values, + initialize objects of this same class type. AKA the C O N S T R U C T O R ~ => can be called when you create a new object using the new keyword
    public BankAccount(string name, decimal initialBalance) {
      this.Owner = name;
      // this.Balance = initialBalance;
      this.Number = accountNumberSeed.ToString();
      accountNumberSeed += 1; 
      MakeDepsit(initialBalance, DateTime.Now, "Initial Balance.");
    }

    // define methods below -> blocks of code that perform a single function 
    public void MakeDepsit(decimal amount, DateTime date, string note) {
      if(amount <= 0) {
        throw new ArgumentOutOfRangeException(nameof(amount),"Ayy, amount of deposit must be positive. What is this voodoo magic?! >__<");
      }
      var deposit = new Transaction(amount, date, note);
      allTransactions.Add(deposit);
    }

    public void MakeWithdrawal(decimal amount, DateTime date, string note) {
      if(amount <= 0) {
        throw new ArgumentOutOfRangeException(nameof(amount), "Ayyy, wait a minute! Amount of withdrawal must be positive!");
      }
      if(Balance - amount < 0) {
        throw new InvalidOperationException("Ayy, hold up! Not enough sufficient funds for this withdrawal.");
      }
      var withdrawal = new Transaction(-amount, date, note);
      allTransactions.Add(withdrawal);
    }
  }
}
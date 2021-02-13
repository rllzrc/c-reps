using System;
using System.Collections.Generic;
using System.Text;

namespace MoneyBagBank {
  public class BankAccount {
    // properties 
    // these are the "form fields"
    public string Number { get; }
    public string Owner { get; set; }
    public decimal Balance { get; }

    // constructor to make the bank account
    // think: this is the form 
    public BankAccount(string name, decimal initialBalance) {
      this.Owner = name;
      this.Balance = initialBalance;
    }

    // methods 
    public void MakeDeposit(decimal amount, DateTime date, string note) {

    }
    
    public void MakeWithdrawal(decimal amount, DateTime date, string note) {
      
    }
  }
}
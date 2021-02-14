using System;

// to provide a logical way to structure the codebase -> this app is v small so all the code will reside in this one namespace
namespace MoneyBagBankBank {
  // the class Bank Account -> this declaration also defines the state + behavior of the class
    public class BankAccount {
    // these are the "form fields" aka properties -> data/elements (can have additional code to enforce type validation + other rules)
    public string Number { get; }
    public string Owner { get; set; }
    public decimal Balance { get; } 
    // not the best way to create an account number per say, but since this app is tiny this will suffice to generate a unique number for each account created => can only be accessed by code inside the BankAccount class -> implementation to generate numbers must remain private -> static = shared by all of the BankAccount objects (the value of a non-static variable is unique to each instance of the BankAccount object)
    private static int accountNumberSeed = 1234567890;

    // to open a new account -> create a new object from the BankAccount class to define, assign values, + initialize objects of this same class type. AKA the C O N S T R U C T O R ~ => can be called when you create a new object using the new keyword
    public BankAccount(string name, decimal initialBalance) {
      this.Owner = name;
      this.Balance = initialBalance;
      this.Number = accountNumberSeed.ToString();
      accountNumberSeed += 1; 
    }

    // define methods below -> blocks of code that perform a single function 
    public void MakeDepsit(decimal amount, DateTime date, string note) {

    }

    public void MakeWithdrawal(decimal amount, DateTime date, string note) {

    }
  }
}
using System;

namespace MoneyBagBank
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Henlo~ World!");
            var account = new BankAccount("Izzi", 20000000);
            Console.WriteLine($"Ayyy!~ Welcome to MoneyBagBankGG! Account {account.Number} was created for {account.Owner} with {account.Balance}.");

            account.MakeWithdrawal(150, DateTime.Now, "Fancy Soaps~");
            Console.WriteLine(account.Balance);

            Console.WriteLine(account.GetAccountHistory());

            // catching error exceptions (guardrails) -> to test that the initial balance remains positive --> to lightly "test" code and catch exception to print to the console
            try {
                var invalidAccount = new BankAccount("invalid", -55);
            }
            catch (ArgumentOutOfRangeExceptione ) {
                Console.WriteLine("Ayy ya yi, exception caught creating account with negative balance!");
                Console.WriteLine(e.ToString());
            }

            // to test negative balances
            try {
                account.MakeWithdrawal(75000, DateTime.Now, "Attempt to overdraw");
            }
            catch (InvalidOperationException e) {
                Console.WriteLine("Ayy! Exception caught -- trying to overdraw over here?!");
                Console.WriteLine(e.ToString());
            }
        }
    }
}

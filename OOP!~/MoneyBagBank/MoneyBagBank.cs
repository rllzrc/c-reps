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
        }
    }
}

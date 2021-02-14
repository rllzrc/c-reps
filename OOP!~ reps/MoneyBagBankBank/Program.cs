using System;

namespace MoneyBagBankBank
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Henlo World!~ ");
            var account = new BankAccount("Izzi", 20000000);
            Console.WriteLine($"Ayyy!! ** GG ~ Welcome to MoneyBagBankBank! ~ Account {account.Number} was created for {account.Owner} with {account.Balance} as its initial balance. Onwards + upwards!~");
        }
    }
}

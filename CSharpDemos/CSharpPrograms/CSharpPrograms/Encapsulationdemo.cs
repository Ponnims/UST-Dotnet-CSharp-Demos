using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPrograms
{

    class BankAccount
    {
        private double Balance;

        public double GetBalance()
        {
            return Balance;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposited: {amount}, New Balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }
    }
    internal class Encapsulationdemo
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            account.Deposit(100);
            Console.WriteLine("Current Balance: " + account.GetBalance());
        }
    }
}

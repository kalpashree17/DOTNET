// See https://aka.ms/new-console-template for more information
// A basic program that demonstrates the use of classes and objects in object-oriented programming

using System;

namespace Lab3
{
    // ✅ BankAccount class
    public class BankAccount
    {
        private string AccountNumber = "";
        private string AccountHolder = "";
        private double Balance;

        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine($"Successfully deposited {amount}. Current balance: {Balance}");
        }

        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Amount to withdraw should be greater than zero.");
            }
            else if (amount > Balance)
            {
                Console.WriteLine("Balance is insufficient.");
            }
            else
            {
                Balance -= amount;
                Console.WriteLine($"Successfully withdrawn {amount}. Remaining balance: {Balance}");
            }
        }

        public void DisplayBalance()
        {
            Console.WriteLine($"Current balance: {Balance}");
        }
    }

    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== OOP Lab 3 ===");
            Console.WriteLine("Program started...\n");

           
            BankAccount acc1 = new BankAccount();

            // Perform operations
            acc1.Deposit(2000);
            acc1.Withdraw(300);
            acc1.DisplayBalance();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

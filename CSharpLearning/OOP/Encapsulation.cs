using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class BankAccount
    {
        
        private double balance;
        public BankAccount(double initialBalance)
        {
            
            this.balance = initialBalance;
        }
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited: {amount}. New Balance: {balance}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrew: {amount}. New Balance: {balance}");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount.");
            }
        }
    }
    internal class Encapsulation
    {
        public static void Main(string[] args)
        {
            BankAccount account = new BankAccount(1000);
            account.Deposit(500);
            account.Withdraw(200);
        }
    }
}
//--Encapsulaton example--
// Bank Account
// Bank Account
// balance 
// Deposit
// Withdraw
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCSharp
{
    class BankAccount
    {
        public delegate void MoneyHandler(string message);
        public event MoneyHandler DepositEvent;
        public void Deposit(int amount)
        {
            Console.WriteLine($"Deposited: {amount}");
            DepositEvent?.Invoke($"You deposited {amount} taka.");
        }

        internal class Event
        {
            public void SendSms(string message)
            {
                Console.WriteLine($"SMS: {message}");
            }
            public void SendEmail(string message)
            {
                Console.WriteLine($"Email: {message}");
            }   
            public static void Main(string[] args)
            {
                BankAccount account = new BankAccount();
                Event obj = new Event();
                account.DepositEvent += obj.SendSms;
                account.DepositEvent += obj.SendEmail;
                account.Deposit(1000);
            }

        }
    }
}

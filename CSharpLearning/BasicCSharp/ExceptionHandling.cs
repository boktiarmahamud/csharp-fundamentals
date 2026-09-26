using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCSharp
{
    class BanckAccount
    {
        public decimal balance { get; private set; } = 1000;
        
        public void Withdraw(decimal amount)
        {
            if(amount <= 0)
            {
                throw new ArgumentException("Withdrawal amount must be greater then 0.");
            }
            if (amount > balance)
            {
                throw new InvalidOperationException("Insufficient funds.");
            }
            balance -= amount;
        }
        public decimal GetBalance()
        {
            return balance;
        }
    }
    internal class ExceptionHandling
    {
        public static void Main(string[] args)
        {

            BanckAccount obj = new BanckAccount();
            try
            {
                obj.Withdraw(1000);
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");

            }
            finally
            {
                Console.WriteLine("Transection completed");
            }


            // basic example of exceptions
            try
            {
                int num = 0;
                int result = 10 / num;
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
            }

            string[] colors = { "Red", "Green", "Blue" };
            try
            {
                Console.WriteLine(colors[4]);

            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Index out of range: " + e.Message);
            }
        }


    }
}

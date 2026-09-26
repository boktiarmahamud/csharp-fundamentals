using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    interface IPayment
    {
        void Pay(double amount);
    }
    class BikashPayment : IPayment
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"payment {amount} done using Bikash");
        }
    }
    class CardPayment : IPayment
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"payment {amount} done using CardPlayment");
        }
    }
    internal class AbstructionAchievedByInterface
    {
        public static void Main(string[] args)
        {
            IPayment bikash = new BikashPayment();
            bikash.Pay(1000);

            IPayment card = new CardPayment(); 
            card.Pay(2000);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class payment
    {
        public virtual void pay(double amount)
        {
            Console.WriteLine($"processing payment of: {amount}");
        }
    }

    class CreditCardPayment : payment
    {
        public override void pay(double amount)
        {
            Console.WriteLine($"paid amount {amount} using Credit Card");
        }
    }
    class Bikash : payment
    {
        public override void pay(double amount)
        {
            Console.WriteLine($"paid amount {amount} using Bikash");
        }
    }
    class Paypal : payment
    {
        public override void pay(double amount)
        {
            Console.WriteLine($"paid amount {amount} using Paypal");
        }
    }   

    class CashOnDelivery : payment
    {
        public override void pay(double amount)
        {
            Console.WriteLine($"paid amount {amount} using Cash on Delivery");
        }
    }   
    internal class RuntimePolymorphism
    {
        public static void Main(string[] args)
        {
            payment obj;
            obj = new CreditCardPayment();
            obj.pay(1000);

            obj = new Bikash();
            obj.pay(2000);

            obj = new Paypal();
            obj.pay(3000);

            obj = new CashOnDelivery();
            obj.pay(4000); 
        }
    }
}

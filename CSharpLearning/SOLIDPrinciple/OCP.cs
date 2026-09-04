using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

namespace SOLIDPrinciple
{
    public interface IPaymentMethod
    { 
        bool Pay(decimal amount);
    }
    public class CreditCardPayment : IPaymentMethod
    {
        private string cardNumber;
        public CreditCardPayment(string cardNumber)
        {
            this.cardNumber = cardNumber;
        }

        public bool Pay(decimal amount)
        {
            if(amount <= 0)
            {
                Console.WriteLine("Invalid payment amount.");
                return false;
            }

            // Validate card 
            if (string.IsNullOrWhiteSpace(cardNumber) || cardNumber.Length != 16)
            {
                Console.WriteLine("Invalid card Number");
                return false;
            }

            // simulate payment processing logic
            Console.WriteLine("connecting to credit card gateway...");
            Console.WriteLine($"Charging credit card ${amount:F2}");

            // simulate successfull
            string transactionId = Guid.NewGuid().ToString();   
            Console.WriteLine("payment successful. Transaction ID: " + transactionId);
            return true;

        }

    }


    public class NagodPayment : IPaymentMethod
    {
        private string mobileNumber;

        public NagodPayment(string mobileNumber)
        {
            this.mobileNumber = mobileNumber;
        }

        public bool Pay(decimal amount)
        {
            if(amount <= 0)
            {
                Console.WriteLine("Invalid payment amount.");
                return false;
            }
            // validate number
            if (string.IsNullOrWhiteSpace(mobileNumber) || mobileNumber.Length != 11)
            {
                Console.WriteLine("Invalid mobile number");
                return false;
            }

            // 3. Simulate Nagad API call
            Console.WriteLine("Connecting to Nagad...");
            Console.WriteLine($"Charging Nagad Account: ${amount:F2}");

            // 4. Simulate successful payment
            string transactionId = Guid.NewGuid().ToString();

            Console.WriteLine("Nagad Payment Successful!");
            Console.WriteLine($"Transaction ID: {transactionId}");
            return true;
        }
    }

    public class PaymentService
    {

        public void ProcessPayment(IPaymentMethod paymentMethod, decimal amount)
        {
            Console.WriteLine("--------------------------------");

            bool result = paymentMethod.Pay(amount);

            if (result)
            {
                Console.WriteLine("Payment completed successfully.");
            }
            else
            {
                Console.WriteLine("Payment failed.");
            }

            Console.WriteLine("--------------------------------");
        }
    }

    internal class OCP
    {
        public static void Main(string[] args)
        {
            PaymentService paymentService = new PaymentService();

            // Credit card payment
            IPaymentMethod creditCardPayment = new CreditCardPayment("1234567812345678");
            paymentService.ProcessPayment(creditCardPayment, 10000);

            // Nagad payment
            IPaymentMethod nagodPayment = new NagodPayment("01712345678");
            paymentService.ProcessPayment(nagodPayment, 5000);
        }
    }
}

// complete OCP example with actual simulated payment logic—validation,
// transaction ID, success/failure, and payment receipt

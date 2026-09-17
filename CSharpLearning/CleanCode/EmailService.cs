using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode
{
    internal class EmailService
    {
        public void SendWelcomeEmail(Customer customer)
        {
            // Simulate sending an email
            Console.WriteLine($"Welcome {customer.Name}");
        }
    }
}

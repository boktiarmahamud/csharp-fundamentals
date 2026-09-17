using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode
{
    internal class CustomerService
    {
        private readonly CustomerValidator _validator = new CustomerValidator();
        private readonly EmailService _emailService = new EmailService();

        public void Register(Customer customer)
        {
            if (!_validator.IsValid(customer))
            {
                Console.WriteLine("Customer is not valid.");
                return;
            }
            Console.WriteLine($"Customer {customer.Name} registered successfully.");
            _emailService.SendWelcomeEmail(customer);
        }
    }
}

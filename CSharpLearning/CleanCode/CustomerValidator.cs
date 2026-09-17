using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode
{
    internal class CustomerValidator
    {
        public bool IsValid(Customer customer)
        {
            return !string.IsNullOrWhiteSpace(customer.Name)
                && !string.IsNullOrWhiteSpace(customer.Email)
                && customer.Email.Contains("@");
        }
    }
}

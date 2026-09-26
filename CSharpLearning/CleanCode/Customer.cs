using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode
{
    internal class Customer
    {
        public string Name { get; }
        public string Email { get; }
        
        public Customer(string Name, string Email)
        {
            this.Name = Name;
            this.Email = Email;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class BaseClass
    {
        public void Display()
        {
            Console.WriteLine("This is the base class method.");
        }
    }
    class DerivedClass : BaseClass
    {
        public new void Display()
        {
            //base.Display(); // Call the base class method
            Console.WriteLine("This is the derived class method.");
        }
    }
    internal class MethodHiding
    {
        public static void Main(string[] args)
        {
           DerivedClass obj = new DerivedClass();
           obj.Display(); // Calls the derived class method
        }   
    }
}

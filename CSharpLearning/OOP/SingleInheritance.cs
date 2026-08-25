using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Parent
    {
        public void display()
        {
            Console.WriteLine("This is a parent class");
        }
    }
    class Child : Parent
    {
        public void display()
        {
            //base.display();
            Console.WriteLine("This is a child class");
        }
    }
    internal class SingleInheritance
    {
        public static void Main(String[] args)
        {
            Child child = new Child();
            child.display();
        }
    }
}

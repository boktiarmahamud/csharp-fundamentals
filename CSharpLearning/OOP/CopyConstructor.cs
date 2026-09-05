using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class CopyConstructorExample
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public CopyConstructorExample(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Copy constructor
        public CopyConstructorExample(CopyConstructorExample other)
        {
            Name = other.Name;
            Age = other.Age;
        }
        public void print()
        {
            Console.WriteLine($"name is: {Name} age {Age}");
        }
    }

    internal class CopyConstructor
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Normal Constructor Example:");

            CopyConstructorExample person1 =
                new CopyConstructorExample("Boktiar", 26);

            person1.print();

            Console.WriteLine("Copy Constructor Example:");

            CopyConstructorExample obj =
                new CopyConstructorExample(person1);

            obj.print();
        }
    }
}

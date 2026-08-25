using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Person1
    {
        public static string Name { get; set; }
        public static int Age { get; set; }
        public static void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name} and I'm {Age} years old.");
        }
    }
    class Instance
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name} and I'm {Age} years old.");
        }
    }
    internal class Static_Instance_method
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Static Method Example:");
            Person1.Name = "Boktiar Mahamud";
            Person1.Age = 25;
            Person1.Introduce();

            Console.WriteLine("\nInstance Method Example:");
            Instance person = new Instance();
            person.Name = "Boktiar Mahamud";
            person.Age = 25;
            person.Introduce();
            Console.ReadLine();
        }
    }
}

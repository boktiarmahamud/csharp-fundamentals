using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciple
{
    public interface IFruit
    {
        string getCOlor();
    }
    class Apple : IFruit
    {
        public string getCOlor()
        {
            return "Red";
        }
    }

    class Orange : IFruit
    {
        public string getCOlor()
        {
            return "Orange";
        }
    }

    internal class LSP
    {
        public static void Main(string[] args)
        {
            IFruit fruit = new Apple();
            Console.WriteLine($"Color of Apple {fruit.getCOlor()}");

            IFruit fruit2 = new Orange();
            Console.WriteLine($"Color of Orange {fruit2.getCOlor()}");
            Console.ReadKey();
        }
    }
}

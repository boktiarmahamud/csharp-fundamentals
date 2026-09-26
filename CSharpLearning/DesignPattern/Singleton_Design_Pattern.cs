using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    public class Singleton
    {
        private static Singleton? _instance;

        private Singleton()
        {
        }

        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }

                return _instance;
            }
        }
    }
    internal class Singleton_Design_Pattern
    {
        public static void Main(string[] args)
        {
            Singleton singleton1 = Singleton.Instance;
            Singleton singleton2 = Singleton.Instance;

            if (singleton1 == singleton2)
            {
                Console.WriteLine("Both instances are the same.");
            }
            else
            {
                Console.WriteLine("Instances are different.");
            }
        }
    }
}

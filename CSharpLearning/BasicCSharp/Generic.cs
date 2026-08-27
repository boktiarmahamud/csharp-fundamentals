using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCSharp
{
    class Box<T>
    {
        public T Value { get; set; }
        public Box(T value)
        {
            Value = value;
        }
        public void show()
        {
            Console.WriteLine($"Value: {Value}");
        }
    }
    internal class Generic
    {
        public void print<T>(T value, T anotherValue)
        {
            Console.WriteLine(value);
            Console.WriteLine(anotherValue);
        }

        public void List<T>(List<T> list)
        {
            foreach (T item in list)
            {
                Console.WriteLine(item);
            }
        }
        public static void Main(string[] args)
        {
            Generic generic = new Generic();
            generic.print<int>(10, 20);
            generic.print<string>("Hello", "World");
            // Create a list of integers
            Console.WriteLine("List of integers:");
            generic.List<int>(new List<int> { 1, 2, 3, 4, 5 });

            //Box class example
            Box<int> obj = new Box<int>(100);
            obj.show();

        }
    }
}

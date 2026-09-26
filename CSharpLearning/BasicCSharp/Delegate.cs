using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCSharp
{
    internal class Delegate
    {
        public void function1()
        {
            Console.WriteLine("Function 1");
        }
        public void function2()
        {
            Console.WriteLine("Funtion 2");
        }
        public delegate void MyDelegate();
        public static void Main(string[] args)
        {
            Delegate obj = new Delegate();
            MyDelegate del = new MyDelegate(obj.function1);
            del += obj.function2; 
            del();
        }
    }
}

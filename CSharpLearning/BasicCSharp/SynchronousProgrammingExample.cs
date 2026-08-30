using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BasicCSharp
{
    internal class SynchronousProgrammingExample
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Start");
            DoWork();
            Console.WriteLine("End");
        }
        static void DoWork()
        {
            Console.WriteLine("work started: ");
            Thread.Sleep(3000); 

            Console.WriteLine("work completed");
        }
    }
}

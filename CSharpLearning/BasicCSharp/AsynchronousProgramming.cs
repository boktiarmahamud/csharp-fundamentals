using System;
using System.Threading.Tasks;

namespace BasicCSharp
{
    internal class AsynchronousProgramming
    {
        public static async Task Main(string[] args)
        {
            Console.WriteLine("Start");

            await DoWork();

            Console.WriteLine("End");
        }

        static async Task DoWork()
        {
            Console.WriteLine("Work started");

            await Task.Delay(3000);

            Console.WriteLine("Work completed");
        }
    }
}
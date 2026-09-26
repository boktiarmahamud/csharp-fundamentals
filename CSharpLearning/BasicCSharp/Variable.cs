using System;

namespace BasicCSharp
{
    internal class Variable
    {
        public static void Run()
        {
            // Variable Declaration
            int age = 25;
            string name = "John";
            double salary = 45000.50;
            char grade = 'A';
            bool isStudent = true;

            // Display Values
            Console.WriteLine("Variables Example");
            Console.WriteLine($"Name      : {name}");
            Console.WriteLine($"Age       : {age}");
            Console.WriteLine($"Salary    : {salary}");
            Console.WriteLine($"Grade     : {grade}");
            Console.WriteLine($"Student   : {isStudent}");

            // Update Variable
            age = 26;

            Console.WriteLine();
            Console.WriteLine("After updating age:");
            Console.WriteLine($"Age       : {age}");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Employee
    {
        public string Name;
        public int EmployeeId;
        public double Salary;

        public void ShowEmployeeInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Employee ID: {EmployeeId}");
            Console.WriteLine($"Salary: ${Salary}");
        }

        public void Work()
        {
            Console.WriteLine($"{Name} is working.");
        }
    }

    class Manager : Employee
    {
        public int NuberOfEmployees;

        public void ManageTeam()
        {
            Console.WriteLine($"{Name} is managing a team of {NuberOfEmployees} employees.");
        }
    }

    class Developer : Employee
    {
        public string ProgrammingLanguage;
        public void WriteCode()
        {
            Console.WriteLine($"{Name} is writing code in {ProgrammingLanguage}.");
        }
    }

    class Accountant : Employee
    {
        public string AccountingSoftware;
        public void PrepareReport()
        {
            Console.WriteLine($"{Name} is preparing a account using {AccountingSoftware}");
        }
    }
    internal class HierarchicalInheritance
    {
        public static void Main(string[] args)
        {
            // Create a Manager object
            Manager manager = new Manager();
            manager.Name = "Boktiar Mahamud";
            manager.NuberOfEmployees = 214006;
            manager.Salary = 100000;
            manager.NuberOfEmployees = 20;

            Console.WriteLine("-- Manager Info --");
            manager.ShowEmployeeInfo();
            manager.Work();
            manager.ManageTeam();

            // Create a Developer object
            Developer developer = new Developer();
            developer.Name = "kamal seikh";
            developer.EmployeeId = 55;
            developer.Salary = 80000;
            developer.ProgrammingLanguage = "C#";

            Console.WriteLine("\n-- Developer Info --");
            developer.ShowEmployeeInfo();
            developer.Work();
            developer.WriteCode();

            // Create an Accountant object
            Accountant accountant = new Accountant();
            accountant.Name = "Istiak prince";
            accountant.EmployeeId = 66;
            accountant.Salary = 70000;
            accountant.AccountingSoftware = "QuickBooks";

            Console.WriteLine("\n-- Accountant Info --");
            accountant.ShowEmployeeInfo();
            accountant.Work();
            accountant.PrepareReport();
        }
    }
}

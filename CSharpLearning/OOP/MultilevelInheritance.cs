using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Person2
    {
        public string Name;
        public int Age;
        
        public void ShowPersonInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
        }
        public void  Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }
    }

    class BankEmployee : Person2
    {
        public string EmployeeID;
        public double Salary;
        public void ShowEmployeeInfo()
        {
            Console.WriteLine($"Employee ID: {EmployeeID}");
            Console.WriteLine($"Salary: {Salary}");
        }

        public void Work()
        {
            Console.WriteLine($"{Name} is working.");
        }
    }
    class BankManager : BankEmployee
    {
        public string Department;
        public int NumberOfEmployees;

        public void ShowManagerInfo()
        {
            Console.WriteLine($"Department: {Department}");
            Console.WriteLine($"Number of Employees: {NumberOfEmployees}");
        }

        public void ManageEmployees()
        {
            Console.WriteLine($"{Name} is managing {NumberOfEmployees} employees in the {Department} department.");
        }
    }
    
    class BranchManager : BankManager
    {
        public string BranchName;
        public double BranchBudget;

        public void ShowBranchManagerInfo()
        {
            Console.WriteLine($"Branch Name: {BranchName}");
            Console.WriteLine($"Branch Budget: {BranchBudget}");
        }

        public void ManageBranch()
        {
            Console.WriteLine($"{Name} is managing the {BranchName} branch with a budget of {BranchBudget}.");
        }
    }
    internal class MultilevelInheritance
    {
        public static void Main(String[] args)
        {
            BranchManager branchManager = new BranchManager();

            // Person properties
            branchManager.Name = "Boktiar Mahamud";
            branchManager.Age = 25;

            // BankEmployee properties
            branchManager.EmployeeID = "EMP123";
            branchManager.Salary = 75000;

            // BankManager properties
            branchManager.Department = "Finance";
            branchManager.NumberOfEmployees = 10;

            // BranchManager properties
            branchManager.BranchName = "Dhaka Branch";
            branchManager.BranchBudget = 500000;

            // Method of person
            branchManager.ShowPersonInfo();
            branchManager.Eat();

            // Method of BankEmployee
            branchManager.ShowEmployeeInfo();
            branchManager.Work();

            // Method of BankManager
            branchManager.ShowManagerInfo();
            branchManager.ManageEmployees();

            // Method of BranchManager
            branchManager.ShowBranchManagerInfo();
            branchManager.ManageBranch();

            
        }
    }
}

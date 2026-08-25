using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    abstract class Employees
    {
        public string Name;
        public double Salary;
        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Salary: {Salary}");
        }

        public abstract void Work();
    }

    class Developers : Employees
    {
        public override void Work()
        {
            Console.WriteLine("Developer writes code.");
        }
    }
    class Managers : Employees
    {
        public override void Work()
        {
            Console.WriteLine("Manager manages the team.");
        }
    }
    internal class AbstructionUsingAbstructClass
    {
        public static void Main(string[] args)
        {
            Developers dev = new Developers();
            dev.Name = "Boktiar";
            dev.Salary = 80000;
            dev.ShowInfo();
            dev.Work();

            Managers mgr = new Managers();
            mgr.Name = "Hasan";
            mgr.Salary = 90000;
            mgr.ShowInfo();
            mgr.Work();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciple
{
    public interface IWorkable
    { 
        public void Work();

    }
    public interface IEatable
    {
        public void Eat();
    }
    public interface ISleepable
    {
        public void Sleep();
    }

    public class HomeWorker : IWorkable, IEatable, ISleepable
    {
        public void Work()
        {
            Console.WriteLine("Home Worker is working");
        }
        public void Eat()
        {
            Console.WriteLine("Home Worker is eating");
        }
        public void Sleep()
        {
            Console.WriteLine("Home Worker is sleeping");
        }
    }

    public class Robot : IWorkable
    {
        public void Work()
        {
            Console.WriteLine("Robot is working");
        }
    }

    internal interface ISP
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Interface Segregation Principle");
            IWorkable homeWorker = new HomeWorker();
            homeWorker.Work();
            
            IEatable homeWorkerEat = new HomeWorker();
            homeWorkerEat.Eat();

            ISleepable homeWorkerSleep = new HomeWorker();
            homeWorkerSleep.Sleep();

            IWorkable robot = new Robot();
            robot.Work();


        }
    }
}

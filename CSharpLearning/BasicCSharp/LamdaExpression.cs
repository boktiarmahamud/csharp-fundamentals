using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCSharp
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    internal class LamdaExpression
    {
        public static void Main(string[] args)
        {
           List<Person> people = new List<Person>()
            {
                new Person(){Name="John", Age=30},
                new Person(){Name="Jane", Age=25},
                new Person(){Name="Jack", Age=35}
            };
            var sortedPeople = people.OrderBy(p => p.Age);
            foreach (var person in sortedPeople)
            {
                Console.WriteLine($"{person.Name} is {person.Age} years old.");
            }
        }
        
    }
}

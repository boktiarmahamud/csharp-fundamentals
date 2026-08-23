using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCSharp
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Marks { get; set; }
    }
    class StudentManager
    {
        private List<Student> students = new List<Student>();
        public delegate void StudentHandler(Student student);
        public event StudentHandler StudentAdded;
        // add student
        public void AddStudent(Student student)
        {
            students.Add(student);
            // Raise the event
            StudentAdded?.Invoke(student);
        }
        public List<Student> GetStudents()
        {
            return students;
        }

    }
    internal class StudentManagement
    {
        static void Main()
        {
            StudentManager manager = new StudentManager();
            manager.StudentAdded += OnStudentAdded;
            manager.AddStudent(new Student { Name = "John", Age = 20, Marks = 85 });
            manager.AddStudent(new Student { Name = "Jane", Age = 22, Marks = 90 });

            var students = manager.GetStudents();
            var passedStudent = students.Where(s => s.Marks >= 60)
                                        .OrderBy(s => s.Marks);

            Console.WriteLine("Passed Students:");
            foreach (var student in passedStudent)
            {
                Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, Marks: {student.Marks}");
            }
        }
        static void OnStudentAdded(Student student)
        {
            Console.WriteLine($"Student added: {student.Name}");
        }



    }
}

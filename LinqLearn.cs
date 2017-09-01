using System;
using System.Linq;
using System.Collections.Generic;
namespace Learn
{
    public static class LinqLearn
    {
        public static void MyMain()
        {
            List<Student> personList = new List<Student>
            {
                new Student(){Name = "Amy", Age = 12},
                new Student(){Name = "Bob", Age = 10},
                new Student(){Name = "Cindy", Age = 11},
                new Student(){Name = "Daug", Age = 20},
                new Student(){Name = "Emmy", Age = 15}
            };
            var oldStudents = from student in personList
                              where student.Age > 13
                              select student;
            foreach (var student in oldStudents)
            {
                Console.WriteLine(student.Name);
            }
        }

        public class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
    }
}

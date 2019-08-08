using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1___LisKov
{
    class Person
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>
            {
                new Student("Abc", "def", 20),
                new Teacher("Zyx", "wvu", 45),
                new Officer("hig", "klm", 35)
            };

            foreach (var person in people)
            {
                Console.Write("First Name:");
                Console.WriteLine(person.FName);
                Console.Write("First Last:");
                Console.WriteLine(person.LName);
                Console.Write("Age:");
                Console.WriteLine(person.Age);
                Console.Write("Job:");
                Console.WriteLine(person.Job());
                Console.Write("\n");
            }
        }
        class Person
        {
            string FName { get; set; }
            string LName { get; set; }
            int Age { get; set; }
            string Job();
        }
        class Student
        {
            public string FName { get; set; }
            public string LName { get; set; }

            public int Age { get; set; }

            public Student(string f, string l, int a)
            {
                FName = f;
                LName = l;
                Age = a;
            }
            public string Job()
            {
                return "Submit Assignments";
            }
        }
        class Teacher
        {
            public string FName { get; set; }
            public string LName { get; set; }

            public int Age { get; set; }

            public Teacher(string f, string l, int a)
            {
                FName = f;
                LName = l;
                Age = a;
            }
            public string Job()
            {
                return "Marks Assignments";
            }
        }
        class Officer
        {
            public string FName { get; set; }
            public string LName { get; set; }

            public int Age { get; set; }

            public Officer(string f, string l, int a)
            {
                FName = f;
                LName = l;
                Age = a;
            }
            public string Job()
            {
                return "Issue Tickets";
            }
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1___LisKov
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>
            {
                new Student{FName = "Abc", LName = "def", Age = 20 },
                new Teacher{FName = "Zyx", LName = "wvu", Age = 45 },
                new Officer{FName = "hig", LName = "klm",Age = 35 }
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

    }


        public class Person
        {
            public string FName { get; set; }
            public string LName { get; set; }
            public int Age { get; set; }

            public virtual string Job()
            {
                return "";
            }
        }
        public class Student : Person
        {
            public override string Job()
            {
                return "Submit Assignments";
            }
        }
        class Teacher : Person
        {
            public override string Job()
            {
                return "Marks Assignments";
            }
        }
        class Officer : Person
        {
            public override string Job()
            {
                return "Issue Tickets";
            }
        }
    

}

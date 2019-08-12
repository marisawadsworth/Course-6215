using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_02
{
    class Person
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public string Email { get; set; }

        public string Introduction(string name)
        {
            return ("Hello, my name is " + name);
        }

        public int DisplayMyAge()
        {
            return 36;
        }

        public int HasBirthday()
        {
            return (36 + 1);
        }

        public int ShowStudentId()
        {
            return 1003004;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person Billy = new Person();
            Billy.FName = "Billy";
            Billy.LName = "Simpson";
            Billy.Email = "billy.simpson@acme.com";

            Billy.Introduction(Billy.FName);
            Billy.DisplayMyAge();
            Billy.HasBirthday();
            Billy.DisplayMyAge();
            Billy.ShowStudentId();

            foreach (var person in people)
            {
                Console.Write("First Name:");
                Console.WriteLine(person.FName);
                Console.Write("First Last:");
                Console.WriteLine(person.LName);
                Console.Write("\n");
            }

        }
    }
}

using System;
using System.Collections.Generic;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IPerson> people = new List<IPerson>
            {
                new Student(10023443, "Bart", "Simpson"),
                new Teacher(2345, "Seymour", "Skinner")
            };

            foreach (var person in people)
            {
                Console.Write("ID:");
                Console.WriteLine(person.Id);
                Console.Write("First Name:");
                Console.WriteLine(person.FName);
                Console.Write("First Last:");
                Console.WriteLine(person.LName);
                Console.Write("Email:");
                Console.WriteLine(person.Email());
                Console.Write("\n");
            }

        }
    }
}
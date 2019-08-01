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
                Console.WriteLine(person.Id);
                Console.WriteLine(person.FName);
                Console.WriteLine(person.LName);
                Console.WriteLine(person.Email());
            }

        }
    }
}
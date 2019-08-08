using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3___Interface_Segregation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IPerson> people = new List<IPerson>
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
    }
}

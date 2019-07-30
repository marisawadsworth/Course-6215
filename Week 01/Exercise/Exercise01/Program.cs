using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_01
{
    class Program
    {
        static List<string> names = new List<string> { "Lisa", "Bob", "Stephen", "Ricky", "Christine" };

        private static void Main(string[] args)
        {
            Console.WriteLine(Messages.quote);
            Console.WriteLine(DisplayNumberOfPeople());

            Console.WriteLine(Messages.names);
            string name = Console.ReadLine();
            AddName(name);

            Console.WriteLine(Messages.arraylist);

            Console.WriteLine(DisplayNames());

            Console.WriteLine(Messages.quote);
            Console.WriteLine(DisplayNumberOfPeople());

            Console.ReadKey();
        }

        private static void AddName(string name)
        {
            names.Add(name);
        }

        private static int DisplayNumberOfPeople()
        {
            return names.Count;
        }

        private static string DisplayNames()
        {
            string output = "";

            foreach (string x in names)
            {
                output += x + " ";
            }

            return output;
        }
    }
}

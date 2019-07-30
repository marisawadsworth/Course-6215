using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_02
{
    class Person
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Email { get; set; }
        public string Introduction { get; set; }
        public int DisplayMyAge { get; set; }
        public Birthday HasBirthday { get; set; }
        public int ShowStudentId { get; set; }

        public void Introduction(string Fname)
        {
            Console.WriteLine("Hello, my name is " + Fname);
        }

        public int DisplayMyAge()
        {
            return 36;
        }

        public int HasBirthday()
        {
            Console.WriteLine(36 + 1);
        }

        public void ShowStudentId()
        {
            Console.WriteLine("1003004");
            Console.ReadKey();
        }
    }
    class Birthday
    {
        public string DisplayMyAge { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person Billy = new Person();
            Billy.Fname = "Billy";
            Billy.Lname = "Simpson";
            Billy.Email = "billy.simpson@acme.com";

            Billy.Introduction(Billy.Fname);
            Billy.DisplayMyAge();
            Billy.HasBirthday();
            Billy.DisplayMyAge();
            Billy.ShowStudentId();
        }
    }
}

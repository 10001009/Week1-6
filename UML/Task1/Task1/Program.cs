using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person1 = new Person();

            Console.WriteLine("Please enter in the first name");
            person1.Fname = Console.ReadLine();

            Console.WriteLine("Please enter in the last name");
            person1.Lname = Console.ReadLine();

            Console.WriteLine("Please enter in the persons age");
            person1.Age = int.Parse(Console.ReadLine());

            Console.WriteLine(person1.ReturnDeets());

            Console.ReadLine();

        }
    }

    class Person
    {
        private string fname;
        private string lname;
        private int age;
        public int counter;

        public string Fname { get { return fname; } set { fname = value; } }
        public string Lname { get { return lname; } set { lname = value; } }
        public int Age { get { return age; } set { age = value; } }

        /*public Person(string _fname, string _lname, int _age)
        {
            Fname = _fname;
            Lname = _lname;
            Age = _age;
        }*/

        public string ReturnDeets()
        {
            return "First name: " + Fname + "\nLast name: " + Lname + "\nAge: " + Age;
        }

    }
}

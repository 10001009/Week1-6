using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[5];

            for (int i = 0; i < students.Length; i++)
            {

                students[i] = new Student();
                Console.WriteLine("Please enter students data");

                Console.WriteLine("Please enter in the students first name: ");
                students[i].Fname = Console.ReadLine();

                Console.WriteLine("Please enter in the students last name: ");
                students[i].Lname = Console.ReadLine();

                Console.WriteLine("Please enter in the students ID: ");
                students[i].StudentId = int.Parse(Console.ReadLine());

            }

            for (int j = 0; j < students.Length; j++)
            {
                Console.WriteLine("\n*****************************");
                Console.WriteLine("Students data");
                Console.WriteLine(students[j].GetStdtDeets());
                Console.WriteLine("*****************************");
            }

            Teacher[] teachers = new Teacher[5];

            for (int k = 0; k < teachers.Length; k++)
            {

                teachers[k] = new Teacher();
                Console.WriteLine("Please enter teachers data");

                Console.WriteLine("Please enter in the teachers first name: ");
                teachers[k].Fname = Console.ReadLine();

                Console.WriteLine("Please enter in the teachers last name: ");
                teachers[k].Lname = Console.ReadLine();

                Console.WriteLine("Please enter in the teachers Employee ID: ");
                teachers[k].EmployeeId = Console.ReadLine();

                Console.WriteLine("Please enter in the teachers office: ");
                teachers[k].Office = Console.ReadLine();

            }

            for (int l = 0; l < teachers.Length; l++)
            {
                Console.WriteLine("\n*****************************");
                Console.WriteLine("Teachers data");
                Console.WriteLine(teachers[l].GetTeachDeets());
                Console.WriteLine("*****************************");
            }

            Console.ReadLine();

        }
    }

    class Person
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
    }

    class Student : Person
    {
        public int StudentId { get; set; }


        public Student(string _fname, string lname, int _stdid)
        {
            Fname = _fname;
            Lname = lname;
            StudentId = _stdid;
        }
        public Student()
        {

        }

        public string GetStdtDeets()
        {
            return "First name: " + Fname + "\nLast Name: " + Lname + "\nStudent ID: " + StudentId;
        }
    }

    class Employee : Person
    {
        public string EmployeeId { get; set; }

    }

    class Teacher : Employee
    {
        public string Office { get; set; }

        public Teacher(string _fname, string _lname, string _empid, string _office)
        {
            Fname = _fname;
            Lname = _lname;
            EmployeeId = _empid;
            Office = _office;
        }
        public Teacher()
        {

        }

        public string GetTeachDeets()
        {
            return "First name: " + Fname + " Last Name: " + Lname + "Employee ID: " + EmployeeId + "Office: " + Office;
               
        }
    }
}

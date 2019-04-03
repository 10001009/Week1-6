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
            Student student = new ITStudent();
            student.Grade1 = 80;
            student.Grade2 = 90;
            student.Grade3 = 100;


            Student student1 = new BusinessStudent();
            student1.Grade1 = 70;
            student1.Grade2 = 60;
            student1.Grade3 = 50;

            Console.WriteLine($"Student's Average: {student.GradeSum()}");
            Console.WriteLine(student1.Largest());

          /*  Student[] array1 = new Student[2];
            array1[0] = student;
            array1[1] = student1;

           

            foreach (Student x in array1)
            {
                if (x.GetType().ToString() == "Task1.ITStudent")
                {
                    x.GradeSum();
                }

                else
                {
                    x.Largest();
                }
            }

            Console.WriteLine(array1[0]);
            Console.WriteLine(array1[1]);
            */

            Console.ReadLine();



        }

        static void Display(Student x)
        {
            Console.WriteLine(x.GetType().ToString());
                if (x.GetType().ToString() == "Task1.ITStudent")
                {
                    x.GradeSum();
                }

                else
                {
                    x.Largest();
                }
            

        }
    }

    class Student
    {
        public int Grade1 { get; set; }
        public int Grade2 { get; set; }
        public int Grade3 { get; set; }

        public virtual int GradeSum()
        {
            return Grade1 + Grade2 + Grade3;
        }

        public virtual string Largest()
        {
            int largest = Grade1;
            if (Grade2 > largest)
                largest = Grade2;
            if (Grade3 > largest)
                largest = Grade3;
            return largest.ToString();    

        }


    }

    class ITStudent : Student
    {
        public override int GradeSum()
        {
            return base.GradeSum()/3;
        }

    }

    class BusinessStudent : Student
    {
        public override string Largest()
        {
            return $"{base.Largest()} is this student's highest grade.";
        }

    }
}

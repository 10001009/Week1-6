using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10001009_Q4
{
    class Program
    {
        static void Main(string[] args)
        {


            Boolean restart = true;

            do
            {
 
                Console.WriteLine("Enter details of new employee below: ");

                Console.Write("First name: ");
                string fname = Console.ReadLine();

                Console.Write("Last name: ");
                string lname = Console.ReadLine();
        
                Employee employee1 = new Employee(fname, lname);

                Console.Write("\nYear employee started working for the company?:");
                employee1.YearStarted = int.Parse(Console.ReadLine());

                Console.WriteLine("\n\n******************************************");
                Console.WriteLine($"Employee {employee1.GetFullName()}, has worked for the company for {employee1.GetYearsWorked()} years");

                Console.WriteLine("\nDo you want to enter another employee? (y/n) : ");
                string check = Console.ReadLine().ToLower();

                if (check == "n")
                {
                    restart = false;
                    
                }

            } while (restart);

            Console.WriteLine("\nPress any key to exit program");
            Console.ReadLine();

        }
    }

   
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10001009_Q5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter details of new employee below: ");

            Console.Write("First name: ");
            string fname = Console.ReadLine();

            Console.Write("Last name: ");
            string lname = Console.ReadLine();

            Console.Write("Year employee started working for the company?:");
            int yearStarted = int.Parse(Console.ReadLine());

            Console.Write("Please enter the type of vehicle this employee will drive: ");
            string vehicle = Console.ReadLine();
            Console.Clear();

            Employee employee1 = new Employee(fname, lname);
            employee1.YearStarted = yearStarted;

            string licenseNo = "";
 
            Driver driver1 = new Driver(fname, lname, vehicle, licenseNo);

            Console.Write("\nPlease enter license number for this employee: ");
            driver1.DriversLicenseNo = Console.ReadLine();

            Console.WriteLine("\nThe following employee details have been Entered: ");
            Console.WriteLine(driver1.ProcessDriver());

            Console.ReadLine();
        }
    }
}

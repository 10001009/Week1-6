using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10001009_Q5
{
    class Driver : Employee
    {

        public string Vehicle { get; set; }
        public string DriversLicenseNo { get; set; }


        public Driver(string firstName, string lastName, string vehicle, string licenseNo) 
        {
            FirstName = firstName;
            LastName = lastName;
            Vehicle = vehicle;
            DriversLicenseNo = licenseNo;

            Console.WriteLine($"Adding Employee as a new Driver to Drive {vehicle}...");
        }
        public Driver()
        {

        }
        

        public string ProcessDriver()
        {
            return "Driver name: " + GetFullName() + "\nDrivers licence No: " + DriversLicenseNo  + "\nVehicle: " + Vehicle;
        }


    }
}

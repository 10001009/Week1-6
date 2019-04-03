using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_Task2
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("\nPLEASE UPDATE STUDENTS DATA");

            Console.WriteLine("Enter students full name: ");
            string fullName = Console.ReadLine();
            CheckString(fullName, "students full name");

            Console.WriteLine("\nEnter Email: ");
            string email = Console.ReadLine();
            CheckString(email, "email");

            Console.WriteLine("\nEnter Address: ");
            string address = Console.ReadLine();
            CheckString(address, "address");

            Console.WriteLine("\nEnter ID: ");
            string id = Console.ReadLine();
            CheckString(id, "ID");

            Console.WriteLine("\nEnter Password: ");
            string password = Console.ReadLine();
            CheckString(password, "password"); 

            StudentRecords student1 = new StudentRecords(fullName, email, address, id, password);

            Console.WriteLine("\nEnter Academic records: ");
            for (int i = 0; i < 4; i++)
            {
               // student1.Results[i] = int.Parse(Console.ReadLine());
                CheckInt(student1.Results[i], "results");
            }           

            Console.WriteLine("\nEnter Emergency Contact Details Name: ");
            student1.Contact.Name = Console.ReadLine();
            CheckString(student1.Contact.Name, "emergency contact name");

            Console.WriteLine("\nEnter Emergency Contact Details Phone: ");
            //student1.Contact.Phone = int.Parse(Console.ReadLine());
            CheckInt(student1.Contact.Phone, "emergency contact phone");

            

            Console.WriteLine(student1.DisplayData());

            Console.ReadLine();


        }

        static string CheckString( string input, string info)
        {
            do
            {
                if (input == "" || input == null)
                {
                    Console.Write($"You need to enter a valid input, please enter the {info}: ");
                    input = Console.ReadLine();
                }

            } while (input == "" || input == null);
            return input;
        }

        public static int CheckInt(int number, string info)
        {

            bool check = true;
            bool confirm = false;

            do
            {

                Console.Write($"Please enter the {info}: ");
                confirm = int.TryParse(Console.ReadLine(), out number);
                do
                {
                    if (!confirm || number < 0)
                    {
                        Console.Clear();
                        Console.Write($"Error, that was not a valid number please try again\nPlease enter the {info}: ");
                        confirm = int.TryParse(Console.ReadLine(), out number);
                    }


                } while (!confirm || number < 0);

             

                Console.WriteLine($"{info} Set\n\n");
                break;

            } while (check);
            return number;



        }

    }
    class StudentRecords
    {
        //Properties
        private string fullName;
        private string email;
        private string address;
        private string id;
        private string password;
        private int[] results = new int[4];   //Array to hold academic records
        private EmergencyContact contact = new EmergencyContact();     //Object class

        //Getters and setters
        public string FullName { get { return fullName; } set { fullName = value; } }
        public string Email { private get { return email; } set { email = value; } }
        public string Address { private get { return address; } set { address = value; } }
        public string Id { get { return id; } set { id = value; } }
        public string Password { private get { return password; } set { password = value; } }
        public int[] Results { get { return results; } set { results = value; } }
        public EmergencyContact Contact { get { return contact; } set { contact = value; } }
        //public int EmergencyContact { private get { return emergencyContact; } set { emergencyContact = value; } }


        //Constructor
        public StudentRecords(string _fullName, string _email, string _address, string _id, string _password /*, int[] _results, EmergencyContact _contact*/)
        {
            FullName = _fullName;
            Email = _email;
            Address = _address;
            Id = _id;
            Password = _password;
            //Results = _results;
            //Contact = _contact;


            Console.WriteLine("A student record has been created ");

        }

        public string DisplayData()
        {
            double average = 0;
            foreach (int x in Results)
                average += x;
            average = average / Results.Length;
            return $"Name: {FullName}\nID: {Id}\nResult 1:{Results[0]}\nResult 2:{Results[1]}\nResult 3:{Results[2]}\nResult 4:{Results[3]}\nAverage: {average}";
        }

    }
    public class EmergencyContact
    {
        private string name;
        private int phone;


        public string Name { private get { return name; } set { name = value; } }
        public int Phone { private get { return phone; } set { phone = value; } }
    }

}

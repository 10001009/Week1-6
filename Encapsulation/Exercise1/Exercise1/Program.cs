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
            Boolean restart = true;

            do
            {

                Console.WriteLine("Please choose which task you want to execute");
                Console.WriteLine("For task 1 press 1");
                Console.WriteLine("For task 2 press 2");
                int choice = Int32.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Creditcard.Exercise1();
                }
                else
                {
                    Employee.Exercise2();
                }

                Console.WriteLine("Do you want to run another task? Y/N");

                var check = Console.ReadLine().ToUpper();
                if (check == "N")
                {
                    restart = false;
                }
                Console.Clear();

            } while (restart);



        }
    }

    //Exercise 1
    class Creditcard
    {
        public static void Exercise1()
        {

            Creditcard card1 = new Creditcard("Card name unknown ", 0, 0, "Expiration date unknown");

            Console.WriteLine("\nPLEASE UPDATE CREDIT CARD DATA");

            Console.WriteLine("\nEnter credit card holders name: ");
            card1.CardName = Console.ReadLine();

            Console.WriteLine("Enter credit card number: ");
            card1.CardNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 3 digit security number: ");
            card1.SecurityNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter expiration date: ");
            card1.Expiration = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("\n*****************************");
            Console.WriteLine("CREDIT CARD DETAILS DISPLAY");
            Console.WriteLine(card1.DisplayCard());
            Console.WriteLine("*****************************");

            Console.ReadLine();

        }

        //private properties
        private string cardName;
        private int cardNumber;
        private int securityNumber;
        private string expiration;


        //Getters and setters
        public string CardName { get { return cardName; } set { cardName = value; } }
        public int CardNumber { private get { return cardNumber; } set { cardNumber = value; } }
        public int SecurityNumber { private get { return securityNumber; } set { securityNumber = value; } }
        public string Expiration { get { return expiration; } set { expiration = value; } }


        //Constructor
        public Creditcard(string _cardName, int _cardNumber, int _securityNumber, string _expiration)
        {
            CardName = _cardName;
            CardNumber = _cardNumber;
            SecurityNumber = _securityNumber;
            Expiration = _expiration;
            Console.WriteLine("New Creditcard object created");


        }

        public string DisplayCard()
        {
            return "Card Holder Name: " + CardName + " Card Expiration Date: " + Expiration;
        }



    }

    //Exercise 2

    class Employee
    {
        public static void Exercise2()
        {
            string fullName = "Unknown", email = "Unknown", username = "Unknown", password = "Unknown";
            int phoneNumber = 0, irdNumber = 0, bankNumber = 0;

            Employee[] employees = new Employee[1];

            for (int i = 0; i < employees.Length; i++)
            {
                
                employees[i] = new Employee(fullName, phoneNumber, email, irdNumber, bankNumber, username, password);
                Console.WriteLine("\nPLEASE UPDATE EMPLOYEES DATA");

                Console.WriteLine("Enter Employees full name: ");
                employees[i].FullName = Console.ReadLine();

                Console.WriteLine("\nEnter Phone number: ");
                employees[i].PhoneNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nEnter Email: ");
                employees[i].Email = Console.ReadLine();

                Console.WriteLine("\nEnter Ird number: ");
                employees[i].IrdNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nEnter Bank number: ");
                employees[i].BankNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nEnter Username: ");
                employees[i].Username = Console.ReadLine();

                Console.WriteLine("\nEnter Password: ");
                employees[i].Password = Console.ReadLine();

            }

            for (int j = 0; j < employees.Length; j++)
            {
                Console.WriteLine("\n*****************************");
                Console.WriteLine("Employees data");
                Console.WriteLine(employees[j].DisplayInfo());
                Console.WriteLine("*****************************");
            }


        }

        //Private properties
        private string fullName;
        private int phoneNumber;
        private string email;
        private int irdNumber;
        private int bankNumber;
        private string username;
        private string password;

        //Getters and Setters
        public string FullName { get { return fullName; } set { fullName = value; } }
        public int PhoneNumber {get  {return phoneNumber;} set { phoneNumber = value;} }
        public string Email {get { return email;} set { email = value;} }
        public int IrdNumber { private get { return irdNumber;} set { irdNumber = value;} }
        public int BankNumber {private get { return bankNumber;} set { bankNumber = value;} }
        public string Username {get {return username;} set { username = value;} }
        public string Password {private get {return password;} set { password = value;} }

        //Constructor
        public Employee(string _fullName, int _phoneNumber, string _email, int _irdNumber, int _bankNumber, string _username, string _password)
        {
            FullName = _fullName;
            PhoneNumber = _phoneNumber;
            Email = _email;
            IrdNumber = _irdNumber;
            BankNumber = _bankNumber;
            Username = _username;
            Password = _password;

            Console.WriteLine("New employee object has been created");

        }

        //Display employees information
        public string DisplayInfo()
        {
            return "Employee's Full name: " + FullName + "\nPhone number: " + PhoneNumber + "\nEmail: " + Email 
                + "\nIrd number: " + IrdNumber + "\nBank number: " + BankNumber + "\nUsername: " + Username + "\nPassword: " + Password;
        }



    }

}

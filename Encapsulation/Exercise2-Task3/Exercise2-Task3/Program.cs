using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_Task3
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = "Unknown", username = "Unknown", password = "Unknown", paymentMethod = "Unknown";

            CustomerDetails customer1 = new CustomerDetails(name, username, password, paymentMethod);

            Console.WriteLine("Please enter new customer data");

            Console.WriteLine("Enter customers name: ");
            customer1.Name = Console.ReadLine();
            CheckString(customer1.Name, "name");

            Console.WriteLine("Enter customers username: ");
            customer1.Username = Console.ReadLine();

            Console.WriteLine("Enter customers password: ");
            customer1.Password = Console.ReadLine();

            Console.WriteLine("Enter customers payment method: ");
            customer1.PaymentMethod = Console.ReadLine();




            Console.ReadLine();
            


        }

        static string CheckString(string input, string info)
        {
            do
            {
                if (input == "" || input == null)
                {
                    Console.Write($"You need to enter a valid input, please enter the customers {info}: ");
                    input = Console.ReadLine();
                }

            } while (input == "" || input == null);
            return input;
        }


    }

    class CustomerDetails
    {
        //Properties
        private string name;
        private string username;
        private string password;
        private string paymentMethod;
        private ShoppingCart cart;

        //Getters and setters
        public string Name { private get { return name; } set { name = value; } }
        public string Username { private get { return username; } set { username = value; } }
        public string Password { private get { return password; } set { password = value; } }
        public string PaymentMethod { get { return paymentMethod; } set { paymentMethod = value; } }
        public List<Item> shoppingCart = new List<Item>();

        //Constructor
        public CustomerDetails(string _name, string _username, string _password, string _paymentMethod)
        {
            Name = _name;
            Username = _username;
            Password = _password;
            PaymentMethod = _paymentMethod;

            Console.WriteLine("New customer object has been created, default data set");

        }

        public void DisplayCart()
        {
            foreach (x item in shoppingCart)
            {

            };

        }

    }


    class Item
    {
        //Properties
        private string itemName;
        private int itemCode;
        private float itemCost;
        private float total;

        //Getters and setters
        public string ItemName { get { return itemName; } set { itemName = value; } }
        public int ItemCode { get { return itemCode; } set { itemCode = value; } }
        public float ItemCost { get { return itemCost; } set { itemCost = value; } }
        public float Total { get { return total; } set { total = value; } }

        //Constructor
        public Item(string _itemName, int _itemCode, float _itemCost, float _total)
        {
            ItemName = _itemName;
            ItemCode = _itemCode;
            ItemCost = _itemCost;
            Total = _total;

            Console.WriteLine("New Shopping cart object has been created, default data set");
        }



    }
}

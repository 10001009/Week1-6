using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Program
    {
        //Main method
        static void Main(string[] args)
        {

            Boolean restart = true;

            do
            {
                int choice = 0;
                Console.WriteLine("Please select a task to access");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("1, 2, 3, 4, 5, 6, 7, 8, 9");
                Console.WriteLine("--------------------------------");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Exercise1();
                        break;

                    case 2:
                        Exercise2();
                        break;

                    case 3:
                        Exercise3();
                        break;

                    case 4:
                        Exercise4();
                        break;

                    case 5:
                        Exercise5();
                        break;

                    case 6:
                        Exercise6();
                        break;

                    case 7:
                        Exercise7();
                        break;

                    case 8:
                        Exercise8();
                        break;

                    case 9:
                        Animal.Exercise10();
                        break;
   
                }

                Console.WriteLine("Do you want to run another task? Y/N");

                var check = Console.ReadLine().ToUpper();
                if( check == "N")
                {
                    restart = false;
                }
                Console.Clear();

            } while (restart);


        }

        //Exercise 1
        public static void Exercise1()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Mabel Cao");

        }

        //Exercise 2
        public static int Exercise2()
        {
            Console.WriteLine("Please enter in the first number to be added");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter in the second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int ans = num1 + num2;

            return ans;

        }

        //Exercise 3
        public static float Exercise3()
        {
            Console.WriteLine("Please enter the first number to be divided");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            float num2 = float.Parse(Console.ReadLine());
            float ans = num1 / num2;

            return ans;

        }

        //Exercise 4
        public static int Exercise4()
        {
            Console.WriteLine("Please enter in the first number to be multiplied");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter in the second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int ans = num1 * num2;

            return ans;
        }

        //Exercise 5
        public static void Exercise5()
        {
            Console.WriteLine("Please enter in a number for multiplication table");
            int num1 = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", num1, i, i * num1);
            }
            return;

        }

        //Exercise 6
        public static void Exercise6()
        {
            Console.WriteLine("Please enter in the radius for the circle");
            double radius = double.Parse(Console.ReadLine());
            double pi = 3.14159;

            double area = pi * (radius * radius);
            double circumference = 2 * pi * radius;

            Console.WriteLine("The circumference is {0}", circumference);
            Console.WriteLine("The area is {0}", area);

        }

        //Exercise 7
        public static void Exercise7()
        {
            int a = 10, b = 20;
            Console.WriteLine("Before swap A={0} B={1}", a, b);

            a = a * b;
            b = a / b;
            a = a / b;
            Console.WriteLine("After swap A={0} B={1}", a, b);

        }
        //Exercise 8
        public static void Exercise8()
        {
            int[] array1 = new int[100];

            Random rand = new Random();


            for (int i = 0; i < 100; i++)
            {
                array1[i] = rand.Next(1000, 9999);
            }

            for (int i = 1; i <= array1.Length; i++)
            {
                Console.WriteLine(array1[i - 1] + "\t\t\t");
                if (i % 7 == 0)
                {
                    Console.WriteLine();
                }
            }


        }

        class Animal
        {
            public static void Exercise10()
            {
                string species = "Unknown", name = "Unknown", age = "Unknown", id = "Unknown";

                Animal[] animals = new Animal[5];
                
                for(int i = 0; i < animals.Length; i++)
                {
                    //Console.WriteLine(animals[i].Species + animals[i].Name + animals[i].Age + animals[i].ID);
                    //Animal animals1 = new Animal("Species unknown", "Name unknown", "Age unknown", "ID number unknown");

                    animals[i] = new Animal(species, name, age, id);
                    Console.WriteLine("\nPLEASE UPDATE ANIMAL DATA");

                    Console.WriteLine("Enter Species: ");
                    animals[i].Species = Console.ReadLine();

                    Console.WriteLine("\nEnter Animals Name: ");
                    animals[i].Name = Console.ReadLine();

                    Console.WriteLine("\nEnter Animals Age: ");
                    animals[i].Age = Console.ReadLine();

                    Console.WriteLine("\nEnter ID number: ");
                    animals[i].ID = Console.ReadLine();

                    
                }

                for (int j = 0; j < animals.Length; j++)
                {
                    Console.WriteLine("\n*****************************");
                    Console.WriteLine("ANIMAL DATA OUTPUT");
                    Console.WriteLine(animals[j].DisplayAnimal());
                    Console.WriteLine("*****************************");
                }
                


                Console.ReadLine();

            }

            //private properties
            private string species;
            private string name;
            private string age;
            private string id;


            //Public getters and setters
            public string Species { get { return species; } set { species = value; } }
            public string Name { get { return name; } set { name = value; } }
            public string Age { get { return age; } set { age = value; } }
            public string ID { get { return id; } set { id = value; } }

            //Public constructor
            public Animal(string _species, string _name, string _age, string _id)
            {
                Species = _species;
                Name = _name;
                Age = _age;
                ID = _id;

            }

            //public method
            public string DisplayAnimal()
            {
                return "Animal species: " + Species + "\nName: " + Name + "\nAge: " + Age + "\nID number: " + ID;
            }
        }
       
    }
}

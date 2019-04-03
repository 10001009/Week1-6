using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises2
{
    class Program
    {
        static void Main(string[] args)
        {

            Boolean restart = true;

            do
            {
                int choice = 0;
                Console.WriteLine("Please select a task to access");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("1, 2, 3, 4, 5, 6, 7");
                Console.WriteLine("--------------------------------");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Exercise1();
                        break;

                  /*  case 2:
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
                        */

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

        //Exercise 1
        public static void Exercise1()
        {
            Console.WriteLine("Please enter a number to specify the array size");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] array1 = new int[size];
            Random rand = new Random();

            for (int i = 0; i < size; i++)
            {
                array1[i] = rand.Next(100);
            }

            Array.Sort(array1);

            for (int j = 0; j < array1.Length; j++)
            {
                Console.WriteLine();
            }

            Console.ReadLine();

        } 

        //Exercise 2
        public static void Exercise2()
        {
            Console.WriteLine("This program will create an array of 100 random numbers from 0 to 100, then it will display the sum of all the numbers");

            int total = 0;

            int[] array1 = new int[100];
            Random rand = new Random();

            for (int i = 0; i <= 100; i++)
            {
                array1[i] = rand.Next(0, 100);
                total += array1[i]; 
            }

            Console.WriteLine("\nThe total of the array items is {0}", total);

            Console.ReadLine();
        }

    }
}

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

            /*
            BoxDimensions box1 = new BoxDimensions(0, 0, 0);

            Console.WriteLine("Please enter in the width of the box");
            BoxDimensions.CheckWidth(box1.Width = float.Parse(Console.ReadLine()));

            Console.WriteLine("Please enter in the length of the box");
            BoxDimensions.CheckLength(box1.Length = float.Parse(Console.ReadLine()));
            

            Console.WriteLine("Please enter in the height of the box");
            BoxDimensions.CheckHeight(box1.Height = float.Parse(Console.ReadLine()));
            

            Console.WriteLine($"The surface area of the box is: {box1.DisplayArea()}");
            Console.WriteLine($"\nThe volume of the box is: {box1.DisplayVolume()}");

            Console.ReadLine();

            */

            int Height = 0;
            int Width = 0;
            int Length = 0;

            Height = BoxDimensions.Validate(Height, "Height");
            Width = BoxDimensions.Validate(Width, "Width");
            Length = BoxDimensions.Validate(Length, "Length");

            BoxDimensions box1 = new BoxDimensions(Height, Width, Length);

            Console.WriteLine($"The surface area of the box is: {box1.DisplayArea()}");
            Console.WriteLine($"\nThe volume of the box is: {box1.DisplayVolume()}");


            Console.ReadLine();

        }

    }
    class BoxDimensions
    {
        //Properties
        private float width;
        private float length;
        private float height;

        //Getters and setters
        public float Width { private get { return width; } set { width = value; } }
        public float Length { private get { return length; } set { length = value; } }
        public float Height { private get { return height; } set { height = value; } }

        //Constructor
        public BoxDimensions(float _width, float _length, float _height)
        {
            Width = _width;
            Length = _length;
            Height = _height;

            Console.WriteLine("Default Box dimensions have been set, new object has been created");
        }

        /*    public static Boolean CheckWidth(float Width)
            {
                if (Width < 0)
                {
                    Console.WriteLine("The width of the data has been accepted and set");
                    return true;
                }
                else
                {
                    Console.WriteLine("The data you entered was not valid, please try again");
                    return false;
                }

            }

            public static Boolean CheckLength(float Length)
            {
                if (Length < 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
            }

            public static Boolean CheckHeight(float Height)
            {
                if (Height < 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }

    */

        //Method to check if input is valid
        public static int Validate(int number, string info)
        {

            bool check = true;
            bool confirm = false;

            do
            {

                Console.Write($"Please enter the {info} of the box: ");
                confirm = int.TryParse(Console.ReadLine(), out number);
                do
                {
                    if (!confirm)
                    {
                        Console.Clear();
                        Console.Write($"Error, that was not a valid number please try again\nPlease enter the {info} of the box: ");
                        confirm = int.TryParse(Console.ReadLine(), out number);
                    }


                } while (!confirm);

                do
                {
                    if (number <= 0)
                    {
                        Console.Clear();
                        Console.Write($"Error, that was not a valid number please try again\nPlease enter the {info} of the box: ");
                        confirm = int.TryParse(Console.ReadLine(), out number);
                    }

                } while (number <= 0);

                Console.WriteLine($"{info} Set\n\n");
                break;

            } while (check);
            return number;



        }


        //Method to display Surface area and volume
        public float DisplayArea()
        {
            //Surface area formula
            float area = 2 * (Height * Width) + 2 * (Height * Length) + 2 * (Width * Length);
            return area;

        }

        public float DisplayVolume()
        {
            //Volume formula
            float volume = Length * Width * Height;
            return volume;
        }
    }
}

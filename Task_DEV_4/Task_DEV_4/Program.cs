using System;

namespace Task_DEV_4
{
    class Rectangle
    {
        private double Length;
        private double Width;

        public Rectangle()
        {

        }

        public Rectangle(double length, int width)
        {
            Length = length;
            Width = width;
        }

        public double PrintWidth()
        {
            {
                Console.WriteLine("Enter width rectangle");
                Width = Convert.ToInt32(Console.ReadLine());
            }
            return Width;
        }

        public double PrintLength()
        {
            {
                Console.WriteLine("Enter length rectangle");
                Length = Convert.ToInt32(Console.ReadLine());
            }
            return Length;
        }

        public double FindArea()
        {
            return Length * Width;
        }

        public double FindPerimetr()
        {
            return Length * 2 + Width * 2;
        }
    }
    class Program
    {
        static void PrintRetangle(string messege)
        {
            Console.WriteLine(messege);
        }

        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            double length = rectangle.PrintLength();
            double width = rectangle.PrintWidth();
            if (length != width)
            {
                double rectangleArea = rectangle.FindArea();
                PrintRetangle($"The area of a rectangle is {rectangleArea}");

                double rectanglePerimetr = rectangle.FindPerimetr();
                PrintRetangle($"The perimetr of a rectangle is {rectanglePerimetr}");
            }
            else
            {
                Console.WriteLine("It's a square");
            }
        }
    }
}
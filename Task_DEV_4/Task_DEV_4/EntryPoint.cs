using System;

namespace Task_DEV_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle ();
            double length = 4;
            double width = 7;
            rectangle.CreateLengthAndWidth(length,width);
            double rectangleArea = rectangle.FindArea();
            Console.WriteLine($"The area of a rectangle is {rectangleArea}");
            double rectanglePerimetr = rectangle.FindPerimetr();
            Console.WriteLine($"The perimetr of a rectangle is {rectanglePerimetr}");
            bool isNotSquare = rectangle.CheckForSquare();
        }
    }
}
using System;

namespace Task_DEV_4
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            double length = 4;
            double width = 7;
            rectangle.SetRectangleParameters(length, width);
            double rectangleArea = rectangle.CalculateArea();
            Console.WriteLine($"The area of a rectangle is {rectangleArea}");
            double rectanglePerimeter = rectangle.CalculatePerimeter();
            Console.WriteLine($"The perimetr of a rectangle is {rectanglePerimeter}");
            if (rectangle.IsSquare())
            {
                Console.WriteLine("This is rectangle");
            }
            else
            {
                Console.WriteLine("This is square");
            }
        }
    }
}

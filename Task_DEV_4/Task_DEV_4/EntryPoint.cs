using System;

namespace Task_DEV_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            double length = 4;
            double width = 7;
            rectangle.SettingFieldValues(length, width);
            double rectangleArea = rectangle.CalculateTheArea();
            Console.WriteLine($"The area of a rectangle is {rectangleArea}");
            double rectanglePerimetr = rectangle.CalculateThePerimeter();
            Console.WriteLine($"The perimetr of a rectangle is {rectanglePerimetr}");
            bool isNotSquare = rectangle.CheckForSquare();
            if (isNotSquare)
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

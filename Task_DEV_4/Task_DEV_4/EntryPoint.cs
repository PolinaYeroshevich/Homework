using System;

namespace Task_DEV_4
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                Square square = new Square(5);
                double squareArea = square.CalculateArea();
                Console.WriteLine($"The area of a square is {squareArea}");
                double squarePerimeter = square.CalculatePerimeter();
                Console.WriteLine($"The perimeter of a square is {squarePerimeter}");

                Rectangle rectangle = new Rectangle(4, 7);
                double rectangleArea = rectangle.CalculateArea();
                Console.WriteLine($"The area of a rectangle is {rectangleArea}");
                double rectanglePerimeter = rectangle.CalculatePerimeter();
                Console.WriteLine($"The perimeter of a rectangle is {rectanglePerimeter}");

                Parallelogram parallelogram = new Parallelogram(2, 3);
                double parallelogramArea = parallelogram.CalculateArea();
                Console.WriteLine($"The area of a paralelogram is {parallelogramArea}");
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

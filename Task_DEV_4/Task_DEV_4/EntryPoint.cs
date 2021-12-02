using System;

namespace Task_DEV_4
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                Triangle triangle = new Triangle("Green", "Triangle", 3, 4, 5);
                double triangleArea = triangle.CalculateArea();
                Console.WriteLine($"The area of a triangle is {triangleArea}");
                double trianglePerimeter = triangle.CalculatePerimeter();
                Console.WriteLine($"The perimeter of a triangle is {trianglePerimeter}");
                String fullInfoTriangle = triangle.GetFullInfo();
                Console.WriteLine(fullInfoTriangle);

                Square square = new Square("Red", "Square", 5);
                double squareArea = square.CalculateArea();
                Console.WriteLine($"The area of a square is {squareArea}");
                double squarePerimeter = square.CalculatePerimeter();
                Console.WriteLine($"The perimeter of a square is {squarePerimeter}");
                String fullInfoSquare = square.GetFullInfo();
                Console.WriteLine(fullInfoSquare);

                Parallelogram parallelogram = new Parallelogram("Blue", "Parallelogram", 9, 7, 5);
                double parallelogramArea = parallelogram.CalculateArea();
                Console.WriteLine($"The area of a paralelogram is {parallelogramArea}");
                double parallelogramPerimeter = parallelogram.CalculatePerimeter();
                Console.WriteLine($"The perimeter of a parallelogram is {parallelogramPerimeter}");
                String fullInfoParallelogram = parallelogram.GetFullInfo();
                Console.WriteLine(fullInfoParallelogram);

                Circle circle = new Circle("Pink", "Circle", 7);
                double circleArea = circle.CalculateArea();
                Console.WriteLine($"The area of a circle is {circleArea}");
                double circlePerimeter = circle.CalculatePerimeter();
                Console.WriteLine($"The perimeter of a circle is {circlePerimeter}");
                String fullInfoCircle = circle.GetFullInfo();
                Console.WriteLine(fullInfoCircle);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

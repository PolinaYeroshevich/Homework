using System;

namespace Task_DEV_4
{
    class Rectangle
    {
        private double length;
        private double width;

        public Rectangle()
        {

        }

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public void SetRectangleParameters(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public double CalculateArea()
        {
            return length * width;
        }

        public double CalculatePerimeter()
        {
            return (length + width) * 2;
        }

        public bool IsSquare()
        {
            return length == width;
        }
    }
}

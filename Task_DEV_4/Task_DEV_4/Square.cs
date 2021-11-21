using System;
namespace Task_DEV_4
{
    class Square
    {
        public double Length { get; set; }

        public Square(double length)
        {
            Length = length;
        }

        public virtual double CalculateArea()
        {
            return Math.Pow (Length, 2);
        }

        public virtual double CalculatePerimeter()
        {
            return Length * 4;
        }
    }
}

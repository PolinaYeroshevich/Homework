using System;

namespace Task_DEV_4
{
    class Square
    {
        public double SideA { get; set; }

        public Square(double sideA)
        {
            SideA = sideA;
        }

        public virtual double CalculateArea()
        {
            return Math.Pow(SideA, 2);
        }

        public virtual double CalculatePerimeter()
        {
            return SideA * 4;
        }
    }
}

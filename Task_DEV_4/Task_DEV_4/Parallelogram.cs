using System;
namespace Task_DEV_4
{
    class Parallelogram : Square
    {
        public double Height { get; set; }
        public double Angle { get; set; }
        public double Width { get; set; }

        public Parallelogram(double length, double height) : base(length)
        {
            Height = height;
        }

        public Parallelogram(double length, double angle, double width) : base(length)
        {
            Length = length;
            Width = width;
            Angle = angle;
        }

        public override double CalculateArea()
        {
            if (Height > 0 && Length > 0)
            {
                return Length * Height;
            }
            else if (Length > 0 && Width > 0 && Angle > 0)
            {
                return Length * Width * Math.Sin(Angle);
            }
            else
            {
                throw new Exception("Custom messege");
            }
        }
    }
}

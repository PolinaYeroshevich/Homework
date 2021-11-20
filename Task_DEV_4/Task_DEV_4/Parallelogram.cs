using System;
namespace Task_DEV_4
{
    class Parallelogram : Square
    {
        public double HeldHeight { get; set; }
        public double Angle { get; set; }
        public double Side { get; set; }

        public Parallelogram(double length, double heldHeight) : base(length)
        {
            HeldHeight = heldHeight;
        }

        public Parallelogram(double length, double angle, double side) : base(length)
        {
            Length = length;
            Side = side;
            Angle = angle;
        }

        public override  double CalculateArea()
        {
            if(HeldHeight > 0)
            {
                return Length * HeldHeight;
            }
            else 
            {
            return Length * Side * Math.Sin(Angle);
            }
        }
    }
}

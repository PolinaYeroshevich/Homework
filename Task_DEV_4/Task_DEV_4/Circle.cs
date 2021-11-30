using System;

namespace Task_DEV_4
{
    class Circle : Figura
    {
        public double Radius { get; set; }
        private const double PI = 3.14;

        public override void CheckForExistance()
        {
            if (Radius <= 0)
            {
                throw new ArgumentOutOfRangeException("Side cannot be less than 0.");
            }
        }

        public Circle(double radius, string name, string color) : base(name, color)
        {
            if (Radius > 0)
            {
                Radius = radius;
            }
        }

        public override double CalculatePerimeter()
        {
            return Radius * 2 * PI;
        }

        public override double CalculateArea()
        {
            return Math.Pow(Radius, 2) * PI;
        }

        public override string GetFullInfo()
        {
            return $"Name : {Name}, Color : {Color}, Radius circle : {Radius}";
        }
    }
}

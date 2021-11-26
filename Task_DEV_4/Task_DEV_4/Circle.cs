using System;

namespace Task_DEV_4
{
    class Circle : Figura
    {
        public double Radius { get; set; }

        public override void CheckForExistance()
        {
            if (Radius <= 0)
            {
                throw new ArgumentOutOfRangeException("Side cannot be less than 0.");
            }
        }

        public Circle(double radius, string name, string color) : base(name, color)
        {
            Radius = radius;
        }

        public override double CalculatePerimeter()
        {
            return Radius * 2 * 3.14;
        }
        public override double CalculateArea()
        {
            return Radius * Radius * 3.14;
        }
        public override string GetFullInfo()
        {
            return $"Name : {Name}, Color : {Color}, Radius circle : {Radius}";
        }
    }
}

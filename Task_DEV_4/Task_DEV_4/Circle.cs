using System;

namespace Task_DEV_4
{
    class Circle : Figure
    {
        private const string INVALID_RANGE_ERROR_MESSAGE = "Radius cannot be less or equal than 0.";

        public double Radius { get; set; }

        public Circle(string color, string name, double radius) : base(color, name)
        {
            Radius = radius;
            CheckForExistence(); 
        }

        public override double CalculateArea()
        {
            return Math.Pow(Radius, 2) * Math.PI;
        }

        public override double CalculatePerimeter()
        {
            return Radius * 2 * Math.PI;
        }

        public override void CheckForExistence()
        {
            if (Radius <= 0)
            {
                throw new ArgumentOutOfRangeException(INVALID_RANGE_ERROR_MESSAGE);
            }
        }

        public override string GetFullInfo()
        {
            return $"Name : {Name}, Color : {Color}, Radius circle : {Radius}";
        }
    }
}

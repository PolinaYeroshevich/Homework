using System;

namespace Task_DEV_4
{
    class Circle : Figure
    {
        private const string MESSAGE_ERROR_FIRST = "Radius cannot be less or equals than 0.";

        public double Radius { get; set; }

        public Circle(string color, string name, double radius) : base(color, name)
        {
            Radius = radius;
            CheckForExistance(); 
        }

        public override double CalculateArea()
        {
            return Math.Pow(Radius, 2) * Math.PI;
        }

        public override double CalculatePerimeter()
        {
            return Radius * 2 * Math.PI;
        }

        public override void CheckForExistance()
        {
            if (Radius <= 0)
            {
                throw new ArgumentOutOfRangeException(MESSAGE_ERROR_FIRST);
            }
        }

        public override string GetFullInfo()
        {
            return $"Name : {Name}, Color : {Color}, Radius circle : {Radius}";
        }
    }
}

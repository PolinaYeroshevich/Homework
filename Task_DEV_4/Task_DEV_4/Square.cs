using System;

namespace Task_DEV_4
{
    class Square : Figure
    {
        private const string ERROR_MESSAGE = "Side cannot be less equals than 0.";

        public double Side { get; set; }

        public Square(string color, string name, double side) : base(color, name)
        {
            Side = side;
            CheckForExistance();
        }

        public override double CalculateArea()
        {
            return Math.Pow(Side, 2);
        }

        public override double CalculatePerimeter()
        {
            return Side * 4;
        }

        public override void CheckForExistance()
        {
            if (Side <= 0)
            {
                throw new ArgumentOutOfRangeException(ERROR_MESSAGE);
            }
        }

        public override string GetFullInfo()
        {
            return $"Name : {Name}, Color : {Color}, Length of side : {Side}";
        }
    }
}

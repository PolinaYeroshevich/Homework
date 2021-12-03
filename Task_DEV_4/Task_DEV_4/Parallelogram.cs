using System;

namespace Task_DEV_4
{
    class Parallelogram : Figure
    {
        private const string INVALID_RANGE_ERROR_MESSAGE = "Side or angle cannot be less or equal than 0.";

        public double Angle { get; set; }
        public double FirstSide { get; set; }
        public double SecondSide { get; set; }

        public Parallelogram(string color, string name, double secondSide,
            double angle, double firstSide) : base(color, name)
        {
            SecondSide = secondSide;
            FirstSide = firstSide;
            Angle = angle;
            CheckForExistence();
        }

        public override double CalculateArea()
        {
            return FirstSide * SecondSide * Math.Sin(Angle);
        }

        public override double CalculatePerimeter()
        {
            return (FirstSide + SecondSide) * 2;
        }

        public override void CheckForExistence()
        {
            if (FirstSide <= 0 || SecondSide <= 0 || Angle <= 0)
            {
                throw new ArgumentOutOfRangeException(INVALID_RANGE_ERROR_MESSAGE);
            }
        }

        public override string GetFullInfo()
        {
            return $"Name : {Name}, Color : {Color}," +
                $" Length of sides : {FirstSide}, {SecondSide}, {Angle}";
        }
    }
}

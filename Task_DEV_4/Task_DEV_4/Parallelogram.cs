using System;

namespace Task_DEV_4
{
    class Parallelogram : Figure
    {
        private const string MESSAGE_ERROR_FIRST = "Side or angle cannot be less or equals than 0.";

        public double Angle { get; set; }
        public double FirstSide { get; set; }
        public double SecondSide { get; set; }

        public Parallelogram(string color, string name, double secondSide,
            double angle, double firstSide) : base(color, name)
        {
            SecondSide = secondSide;
            FirstSide = firstSide;
            Angle = angle;
            CheckForExistance();
        }

        public override double CalculateArea()
        {
            return FirstSide * SecondSide * Math.Sin(Angle);
        }

        public override double CalculatePerimeter()
        {
            return (FirstSide + SecondSide) * 2;
        }

        public override void CheckForExistance()
        {
            if (FirstSide <= 0 || SecondSide <= 0 || Angle <= 0)
            {
                throw new ArgumentOutOfRangeException(MESSAGE_ERROR_FIRST);
            }
        }

        public override string GetFullInfo()
        {
            return $"Name : {Name}, Color : {Color}," +
                $" Length of sides : {FirstSide}, {SecondSide}, {Angle}";
        }
    }
}

using System;

namespace Task_DEV_4
{
    class Parallelogram : Figure
    {
        private const string errorMessage = "Side cannot be less than 0.";
        public double Angle { get; set; }
        public double FirstSide { get; set; }
        public double SecondSide { get; set; }

        public Parallelogram(string color, string name, double secondSide, double angle, double firstSide) : base(color, name)
        {
            SecondSide = secondSide;
            FirstSide = firstSide;
            Angle = angle;
        }

        public override double CalculateArea()
        {
            if (FirstSide > 0 && SecondSide > 0 && Angle > 0)
            {
                return FirstSide * SecondSide * Math.Sin(Angle);
            }
            else
            {
                throw new ArgumentOutOfRangeException(errorMessage);
            }
        }

        public override double CalculatePerimeter()
        {
            if (FirstSide > 0 && SecondSide > 0)
            {
                return (FirstSide + SecondSide) * 2;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Side cannot be less than 0.");
            }
        }

        public override void CheckForExistance()
        {
            if (FirstSide <= 0 || SecondSide <= 0 || Angle <= 0)
            {
                throw new ArgumentOutOfRangeException("Side cannot be less than 0.");
            }
        }

        public override string GetFullInfo()
        {
            return $"Name : {Name}, Color : {Color}, Length of sides : {FirstSide} , {SecondSide}";
        }
    }
}

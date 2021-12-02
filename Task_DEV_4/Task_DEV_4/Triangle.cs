using System;

namespace Task_DEV_4
{
    class Triangle : Figure
    {
        private const string errorMessage = "Side cannot be less than 0.";
        public double BaseSide { get; set; }
        public double FirstSide { get; set; }
        public double SecondSide { get; set; }

        public Triangle(string color, string name, double baseSide, double firstSide, double secondSide) : base(color, name)
        {
            BaseSide = baseSide;
            FirstSide = firstSide;
            SecondSide = secondSide;
            CheckForExistance();
        }

        public override double CalculateArea()
        {
            double perimeter = BaseSide + FirstSide + SecondSide;
            double semiPerimeter = perimeter / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - BaseSide) * (semiPerimeter - FirstSide) * (semiPerimeter - SecondSide));
        }

        public override double CalculatePerimeter()
        {
            return BaseSide + FirstSide + SecondSide;
        }

        public override void CheckForExistance()
        {
            if (BaseSide + FirstSide < SecondSide || BaseSide + SecondSide < FirstSide || SecondSide + FirstSide < BaseSide)
            {
                throw new ArgumentOutOfRangeException("The sum of the two sides cannot be less than the third side.");
            }
            else if (BaseSide <= 0 || FirstSide <= 0 || SecondSide <= 0)
            {
                throw new ArgumentOutOfRangeException(errorMessage);
            }
        }

        public override string GetFullInfo()
        {
            return $"Name : {Name}, Color : {Color}, Length of sides : {BaseSide}, {FirstSide}, {SecondSide}";
        }
    }
}

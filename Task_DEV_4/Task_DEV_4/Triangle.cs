using System;

namespace Task_DEV_4
{
    class Triangle : Figura
    {
        public double BaseSide { get; set; }
        public double FirstSide { get; set; }
        public double SecondSide { get; set; }

        public override void CheckForExistance()
        {
            if (BaseSide + FirstSide < SecondSide)
            {
                throw new ArgumentOutOfRangeException("Side cannot be less than 0.");
            }
            else if (BaseSide + SecondSide < FirstSide)
            {
                throw new ArgumentOutOfRangeException("Side cannot be less than 0.");
            }
            else if (SecondSide + FirstSide < BaseSide)
            {
                throw new ArgumentOutOfRangeException("Side cannot be less than 0.");
            }
            else if (BaseSide <= 0 || FirstSide <= 0 || SecondSide <= 0)
            {
                throw new ArgumentOutOfRangeException("Side cannot be less than 0.");
            }
        }

        public Triangle(double baseSide, double firstSide, double secondSide, string name, string color) : base(name, color)
        {
            if (BaseSide > 0 || FirstSide > 0 || SecondSide > 0)
            {
                BaseSide = baseSide;
                FirstSide = firstSide;
                SecondSide = secondSide;
            }
        }

        public override double CalculatePerimeter()
        {
            return BaseSide + FirstSide + SecondSide;
        }

        public override double CalculateArea()
        {
            double a = BaseSide + FirstSide + SecondSide;
            double b = a / 2;
            return Math.Sqrt(b * (b - BaseSide) * (b - FirstSide) * (b - SecondSide));
        }

        public override string GetFullInfo()
        {
            return $"Name : {Name}, Color : {Color}, Length of sides : {BaseSide}, {FirstSide}, {SecondSide}";
        }
    }
}

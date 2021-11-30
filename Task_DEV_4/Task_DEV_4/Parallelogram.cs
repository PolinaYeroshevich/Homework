using System;

namespace Task_DEV_4
{
    class Parallelogram : Figura
    {
        public double FirstSide { get; set; }
        public double Height { get; set; }
        public double Angle { get; set; }
        public double SecondSide { get; set; }

        public override void CheckForExistance()
        {
            if (Height <= 0 || FirstSide <= 0)
            {
                throw new ArgumentOutOfRangeException("Side cannot be less than 0.");
            }
            else if (FirstSide <= 0 || SecondSide <= 0 || Angle <= 0)
            {
                throw new ArgumentOutOfRangeException("Side cannot be less than 0.");
            }
        }

        public Parallelogram(double firstSide, double height, string name, string color) : base(color, name)
        {
            if (Height > 0 || FirstSide > 0)
            {
                FirstSide = firstSide;
                Height = height;
            }
        }

        public Parallelogram(double secondSide, double angle, double firstSide, string name, string color) : base(color, name)
        {
            if (FirstSide > 0 || SecondSide > 0 || Angle > 0)
            {
                SecondSide = secondSide;
                FirstSide = firstSide;
                Angle = angle;
            }
        }

        public override double CalculateArea()
        {
            if (Height > 0 && FirstSide > 0)
            {
                return FirstSide * Height;
            }
            else if (FirstSide > 0 && SecondSide > 0 && Angle > 0)
            {
                return FirstSide * SecondSide * Math.Sin(Angle);
            }
            else
            {
                throw new ArgumentOutOfRangeException("Side cannot be less than 0");
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

        public override string GetFullInfo()
        {
            return $"Name : {Name}, Color : {Color}, Length of sides : {FirstSide} , {SecondSide}";
        }
    }
}

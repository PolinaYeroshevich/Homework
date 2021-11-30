using System;

namespace Task_DEV_4
{
    class Square : Figura
    {
        public double Side { get; set; }

        public override void CheckForExistance()
        {
            if (Side <= 0)
            {
                throw new ArgumentOutOfRangeException("Side cannot be less than 0.");
            }
        }

        public Square(double side, string color, string name) : base(color, name)
        {
            if (Side > 0)
            {
                Side = side;
            }
        }

        public override double CalculateArea()
        {
            return Math.Pow(Side, 2);
        }

        public override double CalculatePerimeter()
        {
            return Side * 4;
        }

        public override string GetFullInfo()
        {
            return $"Name : {Name}, Color : {Color},Length of side : {Side}";
        }
    }
}

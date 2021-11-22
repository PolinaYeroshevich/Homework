namespace Task_DEV_4
{
    class Rectangle : Square
    {
        public double SideB { get; set; }

        public Rectangle(double sideA, double sideB) : base(sideA)
        {
            SideB = sideB;
        }

        public override double CalculateArea()
        {
            return SideA * SideB;
        }

        public override double CalculatePerimeter()
        {
            return (SideA + SideB) * 2;
        }
    }
}

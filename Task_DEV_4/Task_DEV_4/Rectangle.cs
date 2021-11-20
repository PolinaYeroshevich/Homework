namespace Task_DEV_4
{
    class Rectangle : Square
    {
        public double Width { get; set; }

        public Rectangle(double length, double width) : base(length)
        {
            Width = width;
        }

        public override double CalculateArea()
        {
            return Length * Width;
        }

        public override double CalculatePerimeter()
        {
            return (Length + Width) * 2;
        }
    }
}

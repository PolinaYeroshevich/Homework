namespace Task_DEV_4
{
    class Rectangle : Square
    {
        private double Width { get; set; }
        private double Length { get; set; }

        public Rectangle(double length, double width) : base(length)
        {
            Length = length;
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

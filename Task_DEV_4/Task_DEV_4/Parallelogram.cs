namespace Task_DEV_4
{
    class Parallelogram : Square
    {
        private double Length { get; set; }
        private double HeldHeight { get; set; }
        private double Angle { get; set; }
        private double Side { get; set; }

        public Parallelogram(double length, double heldHeight) : base(length)
        {
            Length = length;
            HeldHeight = heldHeight;
        }

        public Parallelogram(double length, double firstSide, double angle, double side) : base(length)
        {
            Length = firstSide;
            Side = side;
            Angle = angle;
        }

        public override double CalculateArea()
        {
            return Length * HeldHeight;
        }
    }
}

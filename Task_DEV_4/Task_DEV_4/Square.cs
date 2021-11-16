namespace Task_DEV_4
{
    class Square
    {
        private double Length { get; set; }

        public Square(double length)
        {
            Length = length;
        }

        public virtual double CalculateArea()
        {
            return Length * Length;
        }
        public virtual double CalculatePerimeter()
        {
            return (Length + Length) * 2;
        }
    }
}


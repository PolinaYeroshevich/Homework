namespace Task_DEV_4
{
    public abstract class Figure
    {
        public string Color { get; set; }
        public string Name { get; set; }

        public Figure(string color, string name)
        {
            Color = color;
            Name = name;
        }

        public abstract double CalculateArea();

        public abstract double CalculatePerimeter();

        public abstract void CheckForExistance();

        public virtual string GetFullInfo()
        {
            return $"{Name}, {Color}";
        }
    }
}

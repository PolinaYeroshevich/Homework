namespace Task_DEV_4
{
    public abstract class Figura
    {
        public string Name { get; set; }
        public string Color { get; set; }

        public Figura(string name, string color)
        {
            Name = name;
            Color = color;
        }

        public abstract void CheckForExistance();

        public abstract double CalculatePerimeter();

        public abstract double CalculateArea();

        public virtual string GetFullInfo()
        {
            return $"{Name},{Color}";
        }
    }
}

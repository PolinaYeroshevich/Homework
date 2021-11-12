using System;


namespace Task_DEV_4
{
    class Rectangle
    {
        private double length;
        private double width;

        public Rectangle()
        {

        }       

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public void CreateLengthAndWidth(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public double FindArea()
        {
            return length * width;
        }

        public double FindPerimetr()
        {
            return (length + width) * 2;
        }
        
        public bool CheckForSquare ()
        {
            bool isNotSquare = true;
            if (length == width)
            {
                isNotSquare = false;
                Console.WriteLine("It's a square");
            }
            else
            {
                Console.WriteLine("It's not a square");
            }
            return isNotSquare;
        }
    }
}


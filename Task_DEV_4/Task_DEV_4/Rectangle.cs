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

        public void SettingFieldValues(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public double CalculateTheArea()
        {
            return length * width;
        }

        public double CalculateThePerimeter()
        {
            return (length + width) * 2;
        }

        public bool CheckForSquare()
        {
            bool isNotSquare = true;
            if (length == width)
            {
                isNotSquare = false;
            }
            return isNotSquare;
        }
    }
}

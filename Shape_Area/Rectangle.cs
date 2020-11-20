using System;
namespace Shape_Area
{
    class Rectangle : Shape
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

        public override double CaculatePerimeter()
        {
            double perimeter = (length + width) * 2;
                return perimeter;
        }

        public override double CalculateArea()
        {
            double area = this.length * this.width;
            return area;
        }
    }
}

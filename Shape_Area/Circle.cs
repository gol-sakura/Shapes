using System;
namespace Shape_Area
{
    class Circle : Shape
    {
        private double radius;


        public Circle()
        {

        }

        public Circle(double r)
        {
            this.radius = r;
        }

        public override double CaculatePerimeter()
        {
            double perimeter = (double)(2 * radius * Math.PI);
            return perimeter;
        }

        public override double CalculateArea()
        {
            double area = (double)(Math.Pow(this.radius, 2) * Math.PI);
            return area;
        }
    }
}

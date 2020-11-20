using System;
namespace Shape_Area
{
     class Triangle : Shape
    {
        private double trbase;
        private double trheight;
        private double side;

        public Triangle(double trbase, double trheight)
        {
            this.trbase = trbase;
            this.trheight = trheight;
        }

        public Triangle(double trbase, double trheight, double side)
        {
            this.trbase = trbase;
            this.trheight = trheight;
            this.side = side;
        }
        public Triangle()
        {
        }

        public override double CalculateArea()
        {
            double area = (trheight * trbase) / 2;
            return area;
        }

        public override double CaculatePerimeter()
        {
            double perimeter = trheight + trbase + side;
            return perimeter; 
        }
    }
}

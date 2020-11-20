using System;
namespace Shape_Area
{
     class Square : Shape
    {
        
        private double lengthOfSide;


        public Square()
        {

        }

        public Square(double lengthOfSide)
        {
            this.lengthOfSide = lengthOfSide;
            
        }

        public override double CaculatePerimeter()
        {
            double perimeter = 4 * lengthOfSide;
            return perimeter;

        }

        public override double CalculateArea()
        {
            double area = lengthOfSide * lengthOfSide;
            return area;
        }
    }
}

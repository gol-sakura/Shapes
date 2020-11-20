using System;

namespace Shape_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

           // Shape sqaure = new Square(4, 4);

           // Shape circle = new Circle(32);

            bool exit = false;


            while (!exit)
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("--- CHOOSE AN OPTION FROM THE LIST ---");
                Console.WriteLine("------------------------------------\n");

                Console.WriteLine("\t1 - Circle\n");
                Console.WriteLine("\t2 - Square\n");
                Console.WriteLine("\t3 - Rectangle\n");
                Console.WriteLine("\t4 - Triangle\n");
                Console.WriteLine("\t5 - Exit\n");
                Console.WriteLine("\n");
                Console.WriteLine("Your option? ");


                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.WriteLine("--- Circle Area ---\n");
                        Console.WriteLine("Enter circle radius: ");
                        double radius = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\n");
                        Circle circle = new Circle(radius);
                        Console.WriteLine("Area of circle: {0} units", circle.CalculateArea());
                        Console.WriteLine("\n");
                        Console.WriteLine("--- Circle Perimeter ---\n");
                        Console.WriteLine("Perimeter of circle {0} units", circle.CaculatePerimeter());
                        Console.WriteLine("\n");
                        break;
                    case "2":
                        Console.WriteLine("--- Square Area ---\n");
                        Console.WriteLine("Enter square Length side: \n");
                        double side = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\n");
                        Square square = new Square(side);
                        Console.WriteLine("Area of square: {0} units", square.CalculateArea());
                        Console.WriteLine("\n");
                        Console.WriteLine("--- Square Perimeter ---\n");
                        Console.WriteLine("Perimeter of square {0} units", square.CaculatePerimeter());
                        Console.WriteLine("\n");
                        break;
                    case "3":
                        Console.WriteLine("--- Rectangle Area ---\n");
                        Console.WriteLine("Enter rectangle width: \n");
                        double width = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter rectangle length: \n");
                        double length = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\n");
                        Rectangle rec = new Rectangle(width, length);
                        Console.WriteLine("Area of Rectangle: {0} units", rec.CalculateArea());
                        Console.WriteLine("\n");
                        Console.WriteLine("--- Rectangle Perimeter ---\n");
                        Console.WriteLine("Perimeter of rectnagle {0} units", rec.CaculatePerimeter());
                        Console.WriteLine("\n");
                        break;
                    case "4":
                        Console.WriteLine("--- Triangle Area ---\n");
                        Console.WriteLine("Enter triangle base: \n");
                        double trbase = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter triangle height: \n");
                        double trheight = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter triangle side: \n");
                        double side1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\n");
                        Triangle triangle = new Triangle(trbase, trheight);
                        Triangle newtri = new Triangle(trbase, trheight, side1);
                        Console.WriteLine("Area of Triagngle: {0} units", triangle.CalculateArea());
                        Console.WriteLine("\n");
                        Console.WriteLine("--- Triangle Perimeter ---\n");
                        Console.WriteLine("Perimeter of Triagngle: {0} units", newtri.CaculatePerimeter());
                        Console.WriteLine("\n");
                        break;
                    case "5":
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }


        }
    }
}

using System;
using System.Collections.Generic;

namespace QuiltPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            string rec = "rectangle";
            string squ = "square";
            string tri = "triangle";


            // Write shapes

            Console.WriteLine("please select a shape from the following options:");
            Console.WriteLine("\t Triangle \t Square  \t Rectangle \n");

            switch(Console.ReadLine())
            {
                case "triangle":
                    Triangle triangle = new Triangle();
                    triangle.SetShape();
                    triangle.Display();
                    shapes.Add(triangle);
                    break;
                case "square":
                    Square square = new Square();
                    square.SetShape();
                    square.Display();
                    shapes.Add(square);
                    break;
                case "rectangle":
                    Rectangle rectangle = new Rectangle();
                    rectangle.SetShape();
                    rectangle.Display();
                    shapes.Add(rectangle);
                    break;
            }


            // Display shapes




        }
    }
}

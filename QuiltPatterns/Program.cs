using System;
using System.Collections.Generic;

namespace QuiltPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome!");

            string input;
            List<Shape> shapes = new List<Shape>();

            do
            {
                Console.WriteLine("\nEnter 1 to Add a Square!");
                Console.WriteLine("Enter 2 to Add a Rectangle!");
                Console.WriteLine("Enter 3 to Add a Triangle!");
                Console.WriteLine("Enter any thing else to finish!");

                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Square square = new Square();
                        square.SetShape();
                        shapes.Add(square);
                        break;

                    case "2":
                        Rectangle rectangle = new Rectangle();
                        rectangle.SetShape();
                        shapes.Add(rectangle);
                        break;

                    case "3":
                        Triangle triangle = new Triangle();
                        triangle.SetShape();
                        shapes.Add(triangle);
                        break;

                    default:
                        break;
                }

            } while (input.Equals("1") || input.Equals("2") || input.Equals("3"));



            Console.WriteLine();
            Console.WriteLine();

            // Display shapes
            foreach (var shape in shapes)
            {
                shape.Display();
                /*if (shape is Square)
                {
                    Square square = (Square)shape;
                    square.Display();
                } else if (shape is Rectangle)
                {
                    Rectangle rectangle = (Rectangle)shape;
                    rectangle.Display();
                } else if (shape is Triangle)
                {
                    Triangle triangle = (Triangle)shape;
                    triangle.Display();
                }*/
                Console.WriteLine();
            }



        }
    }
}

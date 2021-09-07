using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuiltPatterns
{
    class Rectangle : Shape
    {
        //member variables
        public double Width { get; set; }

        double GetArea()
        {
            return Length * Width;
        }

        public void SetShape()
        {
            // Get Width from user input
            Console.WriteLine("Enter Width : ");
            Width = Convert.ToDouble(Console.ReadLine());

            base.SetShape();
            
            /*// Get Length from user input
            Console.WriteLine("Enter Length : ");
            Length = (double)Console.ReadLine();
            // Get Color from user input
            Console.WriteLine("Enter Color : ");
            Color = Console.ReadLine();*/
        }

        public void Display()
        {
            Console.WriteLine("Rectangle");
            Console.WriteLine("Length: {0}", Length);
            Console.WriteLine("Width: {0}", Width);
            Console.WriteLine("Color: {0}", Color);
            Console.WriteLine("Area: {0}", GetArea());
        }


    }






    }
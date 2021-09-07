using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuiltPatterns
{
    class Triangle : Shape
    {
        //member variables
        public double Heigth { get; set; }

        public double GetArea()
        {
            return 1 / 2 * (Length * Heigth);
        }

        public void SetShape()
        {
            // Get Heigth from user input
            Console.WriteLine("Enter Heigth : ");
            Heigth = Convert.ToDouble(Console.ReadLine());

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
            Console.WriteLine("Triangle");
            Console.WriteLine("Length: {0}", Length);
            Console.WriteLine("Heigth: {0}", Heigth);
            Console.WriteLine("Color: {0}", Color);
            Console.WriteLine("Area: {0}", GetArea());
        }



    }
}

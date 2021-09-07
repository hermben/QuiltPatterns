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

        public new double GetArea()
        {
            return (this.Length * this.Heigth) / 2;
        }

        public new void SetShape()
        {
            // Get Heigth from user input
            Console.WriteLine("Enter Heigth : ");
            Heigth = Convert.ToDouble(Console.ReadLine());

            base.SetShape();
        }

        public new void Display()
        {
            Console.WriteLine("Triangle");
            Console.WriteLine("Length: {0}", Length);
            Console.WriteLine("Heigth: {0}", Heigth);
            Console.WriteLine("Color: {0}", Color);
            Console.WriteLine("Area: {0}", this.GetArea());
        }



    }
}

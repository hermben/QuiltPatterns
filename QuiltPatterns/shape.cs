using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuiltPatterns
{
    class Shape
    {

        //member variables
        public double Length { get; set; }
        public string Color { get; set; }

       public double GetArea()
        {
            return Length * Length;
        }

        public void SetShape()
        {
            // Get Length from user input
            Console.WriteLine("Enter Length : ");
            Length = Convert.ToDouble(Console.ReadLine());
            // Get Color from user input
            Console.WriteLine("Enter Color : ");
            Color = Console.ReadLine();
        }

        
        public virtual void Display()
        {
            Console.WriteLine("Shape");
            Console.WriteLine("Length: {0}", Length);
            Console.WriteLine("Color: {0}", Color);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }
}

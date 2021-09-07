using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuiltPatterns
{
    class Square : Shape
    {
        public new void Display()
        {
            Console.WriteLine("Square");
            Console.WriteLine("Length: {0}", Length);
            Console.WriteLine("Color: {0}", Color);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }
}

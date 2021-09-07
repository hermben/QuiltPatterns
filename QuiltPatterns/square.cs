using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuiltPatterns
{
    class square
    {
        internal double side;
        internal double width;

        double GetArea()
        {
            return side * side;
        }

        public void Display()
        {
            Console.WriteLine("side: {0}", side);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }
}

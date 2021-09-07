using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuiltPatterns
{
    class triangle
    {
        //member variables
        internal double a;
        internal double b;
        internal double h;

        double GetArea()
        {
            return 1 / 2 * (b*h);
        }

        public void Display()
        {
            Console.WriteLine("Length: {0}", a);
            Console.WriteLine("Width: {0}", b);
            Console.WriteLine("Width: {0}", h);
            Console.WriteLine("Area: {0}", GetArea());
        }


    }
}

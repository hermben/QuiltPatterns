using System;

namespace QuiltPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            string rec = "rectangle";
            string squ = "square";
            string tri = "triangle";


            Console.WriteLine("please select a shape from the following options:");
            Console.WriteLine("\t Triangle \t Square  \t Rectangle");
            Console.Write("you have selected a ");


            switch(Console.ReadLine())
            {
                case "triangle":
                    Console.WriteLine($"you have selected a {tri} ");
                    break;
                case "square":
                    Console.WriteLine($"you have selected a {squ} ");
                    break;
                case "rectangle":
                    Console.WriteLine($"you have selected a {rec}");
                    break;

            }



        }
    }
}

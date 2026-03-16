/* Create a class “Rectangle” that would contain length and
width as an instance variable, define constructors
[constructor overloading (default, parameterized)] to
initialize variables of objects.Define methods to find area
and to display variables’
value of objects which are created. */

using System;

namespace Rectangle
{
    class Rectangle
    {
        double length;
        double width;

        public Rectangle()
        {
            length = 0;
            width = 0;
        }

        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }

        public double FindArea()
        {
            return length * width;
        }

        public void Display()
        {
            Console.WriteLine("Length: " + length);
            Console.WriteLine("Width: " + width);
            Console.WriteLine("Area: " + FindArea());
        }
    }

    class Program28
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            Console.WriteLine("REC 1 (Defult Con.) : ");
            r1.Display();

            Console.WriteLine();

            Rectangle r2 = new Rectangle(10, 5);
            Console.WriteLine("REC 2 (Perameterized Con.) : ");
            r2.Display();
        }
    }
}
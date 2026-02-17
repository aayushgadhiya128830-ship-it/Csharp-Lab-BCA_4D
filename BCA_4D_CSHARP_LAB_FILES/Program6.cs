//Write a program to input radius of circle and print area of circle.

using System;

namespace AreaOfCircle
{
    class AreaOfCircle
    {
        static void Main(string[] args)
        {
            double r, a;

            Console.Write("Enter The Radius : ");
            r = Convert.ToDouble(Console.ReadLine());

            a = Math.PI * r * r;

            Console.WriteLine("Area Of Circle is : " + a);
        }
    }
}
// Write a program to find minimum of three number using conditional operator

using System;

namespace MinimumOfThree
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, min;

            Console.Write("Enter first number: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter third number: ");
            c = Convert.ToInt32(Console.ReadLine());

            // Using conditional (ternary) operator
            min = (a < b) ?
                  ((a < c) ? a : c) :
                  ((b < c) ? b : c);

            Console.WriteLine("Minimum number is: " + min);
        }
    }
}
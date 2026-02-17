// Write a program to input priciple amount, rate and year and display compound interest.

using System;

namespace CompoundInterest
{
    class CompoundInterest
    {
        static void Main(string[] args)
        {
            double p, r, t, a, ci;

            Console.Write("Enter The Priciple Amount : ");
            p = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter The Rate : ");
            r = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter The Year : ");
            t = Convert.ToDouble(Console.ReadLine());

            a = p * Math.Pow((1 + r/100),t);
            ci = a - p;

            Console.WriteLine("Compound Interest Is : " + ci);
            Console.WriteLine("Total Amount is : " + a);
        }
    }
}
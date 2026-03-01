//Write a Program to find Fibonacci Series up to a number inputted by user.

using System;

namespace FibonacciSeries
{
    class FibonacciSeries
    {
        static void Main(string[] args)
        {
            int a;

            Console.Write("Enter The Number : ");
            a = Convert.ToInt32(Console.ReadLine());

            int b = 0,c = 1,d;

            Console.WriteLine("Fibonacci Series Of " + a + " is : ");
            for (int i = 0; i <= a; i++)
            {
                d = b + c;
                Console.WriteLine(d + " ");
                b = c;
                c = d;
            }
        }
    }
}
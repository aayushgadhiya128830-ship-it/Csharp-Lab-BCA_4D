// Write a Program to find factorial of given number

using System;

namespace Factorial
{
    class Factorial
    {
        static void Main(string[] args)
        {
            int a;

            Console.Write("Enter The Number : ");
            a = Convert.ToInt32(Console.ReadLine());

            long f = 1;
            for (int i = 1; i <= a; i++)
            {
                f *= i;
            }
            if (a == 0)
            {
                Console.WriteLine("Factorial Not Working With Zero!! ");
                return;
            }
            Console.WriteLine("Factorial of " + a + " is : " + f);
        }
    }
}
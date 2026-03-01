//Write a Program to check weather a number inputted by user is prime or not.

using System;

namespace Prime
{
    class Prime
    {
        static void Main(string[] args)
        {
            int n;
            bool isPrime = true;

            Console.Write("Enter The Number : ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n <= 1)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i <= n / 2; i++)
                {
                    if (n % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }
            if (isPrime)
            {
                Console.WriteLine("Number " + n + " is Prime");
            }
            else
            {  
                Console.WriteLine("Number " + n + " is Not Prime");
            }
            Console.WriteLine();
        }
    }
}
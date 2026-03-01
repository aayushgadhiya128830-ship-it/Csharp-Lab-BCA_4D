//Write a program to find all prime number between two values inputted by user

using System;

namespace PrimeBetTwoNum
{
    class PrimeBetTwoNum
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.Write("Enter The Stating Range : ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter The Ending Range : ");
            b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("Invalid Range!!");
                return;
            }
            
            Console.WriteLine($"Prime Number Between {a} and {b} : ");
            for (int i = a; i <= b; i++)
            {
                if (IsPrime(i))
                {
                    Console.WriteLine(i + " ");
                }
            }
        }

        static bool IsPrime(int n)
        {
            if(n <= 1)

                return false;
            for(int i = 2;i <= n; i++)
            {
                if (n % i == 0)

                    return false;
            }
            return true;
        }
    }
}
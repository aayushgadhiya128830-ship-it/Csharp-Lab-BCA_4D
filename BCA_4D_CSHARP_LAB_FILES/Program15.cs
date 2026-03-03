// Write a program to calculate sum of number inputted by the user.

using System;

namespace SumOfNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, sum = 0;

            Console.Write("Enter a Number: ");
            number = Convert.ToInt32(Console.ReadLine());

            int temp = number;

            while (temp != 0)
            {
                sum += temp % 10;   // Get last digit
                temp /= 10;         // Remove last digit
            }

            Console.WriteLine("Sum of digits of " + number + " is: " + sum);
        }
    }
}
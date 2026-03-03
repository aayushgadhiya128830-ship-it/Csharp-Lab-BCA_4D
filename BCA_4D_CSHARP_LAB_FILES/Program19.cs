// Write a program to check weather a number is Armstrong or not.

using System;

namespace ArmstrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, originalNumber, remainder;
            int sum = 0;

            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());

            originalNumber = number;

            while (number != 0)
            {
                remainder = number % 10;              // Get last digit
                sum += remainder * remainder * remainder;  // Cube and add
                number /= 10;                        // Remove last digit
            }

            if (sum == originalNumber)
                Console.WriteLine("Number is Armstrong.");
            else
                Console.WriteLine("Number is Not Armstrong.");
        }
    }
}
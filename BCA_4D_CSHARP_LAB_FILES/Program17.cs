// Write a program to check weather a number is palindrome or not.

using System;

namespace PalindromeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, originalNumber, remainder, reverse = 0;

            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());

            originalNumber = number;

            while (number != 0)
            {
                remainder = number % 10;     // Get last digit
                reverse = reverse * 10 + remainder;  // Build reverse number
                number = number / 10;        // Remove last digit
            }

            if (originalNumber == reverse)
                Console.WriteLine("Number is Palindrome.");
            else
                Console.WriteLine("Number is Not Palindrome.");
        }
    }
}
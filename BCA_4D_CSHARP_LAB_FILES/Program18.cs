// Write a program to check weather a string is palindrome or not.

using System;

namespace StringPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string input, reverse = "";

            Console.Write("Enter a string: ");
            input = Console.ReadLine();

            // Reverse the string
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reverse += input[i];
            }

            // Check palindrome
            if (input.Equals(reverse, StringComparison.OrdinalIgnoreCase))
                Console.WriteLine("String is Palindrome.");
            else
                Console.WriteLine("String is Not Palindrome.");
        }
    }
}
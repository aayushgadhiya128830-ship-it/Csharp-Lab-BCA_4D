// Write a program to display maximum number from inputted 5 numbers from user.

using System;

class Program
{
    static void Main()
    {
        int num, max;

        Console.Write("Enter number 1: ");
        max = Convert.ToInt32(Console.ReadLine());

        for (int i = 2; i <= 5; i++)
        {
            Console.Write("Enter number " + i + ": ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num > max)
            {
                max = num;
            }
        }

        Console.WriteLine("Maximum number is: " + max);
    }
}
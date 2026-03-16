/* Count Positive and Negative Numbers using array
Store 8 numbers in an array.
Use a loop to traverse the array.
Use if condition to count positive and negative numbers separately. */

using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[8];
        int positiveCount = 0, negativeCount = 0;

        // Input 8 numbers
        Console.WriteLine("Enter 8 numbers:");
        for (int i = 0; i < 8; i++)
        {
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Traverse array and count
        for (int i = 0; i < 8; i++)
        {
            if (numbers[i] >= 0)
            {
                positiveCount++;
            }
            else
            {
                negativeCount++;
            }
        }

        Console.WriteLine("Positive numbers: " + positiveCount);
        Console.WriteLine("Negative numbers: " + negativeCount);
    }
}
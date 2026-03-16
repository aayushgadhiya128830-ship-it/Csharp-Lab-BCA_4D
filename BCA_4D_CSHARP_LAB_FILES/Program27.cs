/* Calculate Sum and Average
Store marks of 5 students in an array.
Use a loop to calculate total marks.
Calculate and display the average. */

using System;

class Program
{
    static void Main()
    {
        int[] marks = new int[5];
        int sum = 0;
        double average;

        // Input marks
        Console.WriteLine("Enter marks of 5 students:");
        for (int i = 0; i < 5; i++)
        {
            marks[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Calculate sum
        for (int i = 0; i < 5; i++)
        {
            sum += marks[i];
        }

        // Calculate average
        average = sum / 5.0;

        Console.WriteLine("Total Marks: " + sum);
        Console.WriteLine("Average Marks: " + average);
    }
}
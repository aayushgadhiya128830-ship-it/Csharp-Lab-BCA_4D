// Write a program to determine loan eligibility based on age, income, and credit score using nested conditions.

using System;

class Program
{
    static void Main()
    {
        int age, creditScore;
        double income;

        Console.Write("Enter Age: ");
        age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Monthly Income: ");
        income = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Credit Score: ");
        creditScore = Convert.ToInt32(Console.ReadLine());

        if (age >= 18)
        {
            if (income >= 25000)
            {
                if (creditScore >= 700)
                {
                    Console.WriteLine("Loan Approved");
                }
                else
                {
                    Console.WriteLine("Loan Rejected: Credit score too low");
                }
            }
            else
            {
                Console.WriteLine("Loan Rejected: Income too low");
            }
        }
        else
        {
            Console.WriteLine("Loan Rejected: Age must be at least 18");
        }
    }
}
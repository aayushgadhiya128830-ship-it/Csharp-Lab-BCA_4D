// Write a program that calculates bill and gives discount based on customer category (senior citizen, regular, industrial).

using System;

class Program
{
    static void Main()
    {
        double amount, discount = 0, finalBill;
        int category;

        Console.Write("Enter total bill amount: ");
        amount = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nCustomer Categories:");
        Console.WriteLine("1. Senior Citizen");
        Console.WriteLine("2. Regular Customer");
        Console.WriteLine("3. Industrial Customer");
        Console.Write("Enter category number: ");
        category = Convert.ToInt32(Console.ReadLine());

        switch (category)
        {
            case 1:
                discount = amount * 0.20;
                Console.WriteLine("Category: Senior Citizen");
                break;

            case 2:
                discount = amount * 0.10;
                Console.WriteLine("Category: Regular Customer");
                break;

            case 3:
                discount = amount * 0.05;
                Console.WriteLine("Category: Industrial Customer");
                break;

            default:
                Console.WriteLine("Invalid category!");
                return;
        }

        finalBill = amount - discount;

        Console.WriteLine("Original Amount: " + amount);
        Console.WriteLine("Discount: " + discount);
        Console.WriteLine("Final Bill Amount: " + finalBill);
    }
}
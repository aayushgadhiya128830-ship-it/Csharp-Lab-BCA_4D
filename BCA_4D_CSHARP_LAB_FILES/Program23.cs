// Write a program to verify PIN first, then allow withdrawal only if balance is sufficient.

using System;

class Program
{
    static void Main()
    {
        int pin, enteredPin;
        double balance = 5000, withdrawAmount;

        pin = 1234;   // Correct PIN

        Console.Write("Enter your PIN: ");
        enteredPin = Convert.ToInt32(Console.ReadLine());

        if (enteredPin == pin)
        {
            Console.Write("Enter withdrawal amount: ");
            withdrawAmount = Convert.ToDouble(Console.ReadLine());

            if (withdrawAmount <= balance)
            {
                balance = balance - withdrawAmount;
                Console.WriteLine("Withdrawal Successful");
                Console.WriteLine("Remaining Balance: " + balance);
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
        }
        else
        {
            Console.WriteLine("Invalid PIN");
        }
    }
}
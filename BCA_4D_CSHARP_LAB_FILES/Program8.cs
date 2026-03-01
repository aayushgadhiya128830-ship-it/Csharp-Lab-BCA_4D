/* write a program to input age of person and display massage as follow - 
 * if age < 12 print you are kid,
 * if age between 12 to 17 print you are teenager and
 * if age is between 18 to 60 print you are adult and
 * if age > 60 print you are senior citizen. */

using System;

namespace AgeCom
{
    class Agecom
    {
        static void Main(string[] args)
        {
            Console.Write("Enter The Age : ");
            int a = int.Parse(Console.ReadLine());

            if (a < 12)
            {
                Console.WriteLine("You are Kid");
            }
            else if (a >= 12 && a <= 17)
            {
                Console.WriteLine("You are Teenager");
            }
            else if (a >= 18 && a <= 60)
            {
                Console.WriteLine("You are Adult");
            }
            else
            {
                Console.WriteLine("You are Senior Citizen");
            }
        }
    }
}
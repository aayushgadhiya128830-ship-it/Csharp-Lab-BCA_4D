/* Application that vaildates user login credentials using a predefination username and password with limited login attempts 
 * Conditional statements, loops */

using System;

namespace Login
{
    class Login
    {
        static void Main(string[] args)
        {
            string Username = "admin";
            string Password = "123";

            int Attempts = 3;

            while (Attempts > 0)
            {
                Console.Write("Enter The Username : ");
                string u = Console.ReadLine();

                Console.Write("Enter The Password : ");
                string p = Console.ReadLine();

                if (u == Username && p == Password)
                {
                    Console.WriteLine("Login Successfull !! Welcome User.");
                    break;
                }
                else
                {
                    Attempts--;
                    Console.WriteLine("Invalid Login");

                    if (Attempts == 0)
                    {
                        Console.WriteLine("Remainimg Attempts : " + Attempts);
                    }
                    else
                    {
                        Console.WriteLine("Account Locked!!");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
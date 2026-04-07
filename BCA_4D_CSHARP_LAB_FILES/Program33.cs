// Write a program demonstrate the use of try and catch in c#.

using System;

namespace TryCatch
{
    class TryCatch
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter The 1st Number : ");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter The 2nd Number : ");
                int b = Convert.ToInt32(Console.ReadLine());

                int c = a + b;

                Console.WriteLine("Sum Is : " + c);

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error : Cannot Divide By Zero...");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error : Invalid Input, Please Numeric Values...");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected Error : " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Program Execute Complete...");
            }

        }
    }
}
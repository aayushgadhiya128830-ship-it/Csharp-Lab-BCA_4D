// write a program demonstrate the use of try , catch and finaly in c#.

using System;

namespace TryCatchFinally
{
    class TryCatchFinally
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter The 1st Number : ");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter The 2nd Number : ");
                int b = Convert.ToInt32(Console.ReadLine());

                int c = a / b;

                Console.WriteLine("Divition Is : " + c);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error : Cannot Be Zero Divied...");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error : Invalid Format, Please Enter Numeric Values...");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected Error : " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Program Execution Complete...");
            }
        }
    }
}
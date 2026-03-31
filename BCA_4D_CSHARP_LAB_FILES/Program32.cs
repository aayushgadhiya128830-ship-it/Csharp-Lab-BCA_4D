/* Definition : Write a program to implement an interface called
 * with a method Pass(int mark) that returns a boolean value.
 * Write another interface called with a method Division(int average)
 * that returns a String. Create a class called which implements
 * both the and interfaces. The Pass method should return if
 * the mark is greater than or equal to 50, otherwise it should return .
The Division method should return */

using System;

namespace Result
{
    interface IResult
    {
        bool Pass(int mark);
    }

    interface IDivision
    {
        string Division(int average);
    }

    class Std : IResult, IDivision
    {
        public bool Pass(int mark)
        {
            if(mark > 40)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Division(int average)
        {
            if (average >= 90)
            {
                return "1st Division";
            }
            else if (average >= 75)
            {
                return "2nd Division";
            }
            else if (average >= 60)
            {
                return "3rd Division";
            }
            else if (average > 40)
            {
                return "4th Division";
            }
            else
            {
                return "Fail";
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Std s = new Std();

            Console.Write("Enter The Mark : ");
            int mark = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter The Average : ");
            int avg = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Pass Result : " + s.Pass(mark));
            Console.WriteLine("Division : " + s.Division(avg));
        }
    }
}
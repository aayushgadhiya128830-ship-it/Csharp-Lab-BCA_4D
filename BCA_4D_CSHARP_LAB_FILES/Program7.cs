/* write a program to input a number and print whether it is a even or odd */

using System;

namespace EvenorOdd
{
    class EvenorOdd
    {
        static void Main(string[] args)
        {
            Console.Write("Entre The Number For : ");
            int a = int.Parse(Console.ReadLine());

            if (a%2==0){
                Console.WriteLine("Number " + a + " is Even");
            }

            else{
                Console.WriteLine("Number " + a + " is Odd");
            }
        }
    }
}
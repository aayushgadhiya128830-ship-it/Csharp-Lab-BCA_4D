using System;

namespace ConsoleApp1
{
    class Arithematic
    {
        static void Main(string[] args)
        {
            Console.Write("Entre The Number For A : ");
            int A = int.Parse(Console.ReadLine());

            Console.Write("Entre The Number For B : ");
            int B = int.Parse(Console.ReadLine());

            Console.WriteLine("Add : " + (A + B));
            Console.WriteLine("Sub : " + (A - B));
            Console.WriteLine("Mul : " + (A * B));
            Console.WriteLine("Div : " + (A / B));

        }
    }
}
using System;

namespace Relational
{
    class Relational
    {
        static void Main(string[] args)
        {
            Console.Write("Entre The Number For A : ");
            int A = int.Parse(Console.ReadLine());

            Console.Write("Entre The Number For B : ");
            int B = int.Parse(Console.ReadLine());

            Console.WriteLine(A + "==" + B + "is" + (A == B));
            Console.WriteLine(A + "!=" + B + "is" + (A != B));
            Console.WriteLine(A + "<" + B + "is" + (A < B));
            Console.WriteLine(A + ">" + B + "is" + (A > B));
            Console.WriteLine(A + "<=" + B + "is" + (A <= B));
            Console.WriteLine(A + ">=" + B + "is" + (A >= B));
        }
    }
}
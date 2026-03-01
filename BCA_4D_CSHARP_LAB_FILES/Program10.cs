// write  a program to create two variables with integers and float and
// perform automatically conversion as well as force conversion  

using System;

namespace Program
{
    class AutoConForce
    {
        static void Main(string[] args)
        {
            float sal;
            int a = 100;
            sal = a;
            Console.WriteLine(sal);

            float sal1 = 100;
            int a2;
            a2 = (int)sal1;
            Console.WriteLine(a2);
        }
    }
}   
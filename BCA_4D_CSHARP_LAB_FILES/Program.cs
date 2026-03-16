/* Write a program to calculate electricity bill based on unit slabs. Add a fixed meter charge and apply GST if the bill exceeds a certain amount. 
First 100 units → ₹1.5/unit



Next 100 units → ₹2.5/unit



Above 200 units → ₹4/unit



Fixed meter charge → ₹50



GST → 18% if bill > ₹500 */


using System;

namespace ElectricityBill
{
    class Program
    {
        static void Main(string[] args)
        {
            int units;
            double bill = 0, gst = 0;
            const double fixedCharge = 50;

            Console.Write("Enter electricity units consumed: ");
            units = Convert.ToInt32(Console.ReadLine());

            // Calculate bill based on slabs
            if (units <= 100)
            {
                bill = units * 1.5;
            }
            else if (units <= 200)
            {
                bill = (100 * 1.5) + ((units - 100) * 2.5);
            }
            else
            {
                bill = (100 * 1.5) + (100 * 2.5) + ((units - 200) * 4);
            }

            // Add fixed meter charge
            bill += fixedCharge;

            // Apply GST if bill > 500
            if (bill > 500)
            {
                gst = bill * 0.18;
                bill += gst;
            }

            Console.WriteLine("\nFixed Charge: ₹" + fixedCharge);
            Console.WriteLine("GST Applied: ₹" + gst);
            Console.WriteLine("Total Electricity Bill: ₹" + bill);
        }
    }
}
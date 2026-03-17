/* Create a class “Employee” that contains employeeId, name, and salary
 * as instance variables. Define constructors (default and parameterized)
 * to initialize the values. Create methods to calculate annual salary and
 * display employee information. */

using System;

namespace SalaryCal
{
    class SalaryCal
    {
        int id;
        string name;
        double salary;

        public SalaryCal()
        {
            id = 0;
            name = "xyz";
            salary = 00.00;
        }

        public SalaryCal(int i, string n, double s)
        {
            id = i;
            name = n;
            salary = s;
        }

        public double CalculateSalary()
        {
            salary *= 12;
            return salary;
        }

        public void Display()
        {
            Console.WriteLine("Employee Id : " + id);
            Console.WriteLine("Employee Name : " + name);
            Console.WriteLine("Employee Salary : " + salary);
            Console.WriteLine("Employee Annual Salary : " + CalculateSalary());
        }
    }

    class Program30
    {
        static void Main(string[] args)
        {
            SalaryCal sl1 = new SalaryCal();
            Console.WriteLine("Employee Information (Default Con.): ");
            sl1.Display();

            SalaryCal sl2 = new SalaryCal(1001, "Abc", 10000);
            Console.WriteLine("Employee Information (Parameterized Con.): ");
            sl2.Display();
        }
    }
}
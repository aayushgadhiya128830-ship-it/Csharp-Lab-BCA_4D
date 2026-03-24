/* Create a class that contains instance variables such as and . Derive two classes from it named and .


The class should include an additional instance variable called , while the class should include an instance variable called .


Define appropriate methods in all classes to perform operations like for both Savings and Current accounts. Use the concept of 
and implement method overriding where required. */

using System;
using System.Runtime.Intrinsics.Arm;

namespace Bank
{
    abstract class Account
    {
        protected int accNo;
        protected string name;
        protected double balance;

        public Account(int a, string n, double b)
        {
            accNo = a;
            name = n;
            balance = b;
        }

        public abstract void Deposit(double amount);
        public abstract void Withdraw(double amount);

        public void show()
        {
            Console.WriteLine(accNo + " " + name + " " + balance);
        }
    }

    class Savings : Account
    {
        double interest;

        public Savings(int a, string n, double b, double i)
            : base(a, n, b)
        {
            interest = i;
        }

        public override void Deposit(double amount)
        {
            balance += amount + (amount * interest / 100);
            Console.WriteLine("Savings Deposits");
        }

        public override void Withdraw(double amount)
        {
            balance -= amount;
            Console.WriteLine("Savings Withdraw");
        }
    }

    class Current : Account
    {
        double overdraft;

        public Current(int a, string n, double b, double o)
            : base(a, n, b)
        {
            overdraft = o;
        }

        public override void Deposit(double amount)
        {
            balance += amount;
            Console.WriteLine("Current Deposit");
        }

        public override void Withdraw(double amount)
        {
            if (balance + overdraft >= amount)
            {
                balance -= amount;
                Console.WriteLine("Current Withdraw");
            }
            else
            {
                Console.WriteLine("Limit Exceeded");
            }
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Account s = new Savings(1, "Ram", 5000, 5);
            s.Deposit(1000);
            s.show();

            Account c = new Current(1, "Shyam", 4000, 2000);
            c.Withdraw(1000);
            c.show();
        }
    }
}
/* Create a class “Student” that contains rollNo, name, and marks
as instance variables. Define constructors (default and parameterized)
to initialize these variables. Create methods to calculate grade based
on marks and display student details. */

using System;

namespace Student
{
    class Student
    {
        int roll;
        string name;
        double marks;

        public Student()
        {
            roll = 0;
            name = "xyz";
            marks = 0;
        }

        public Student(int r, string n, double m)
        {
            roll = r;
            name = n;
            marks = m;
        }

        public string CalculateGrade()
        {
            if (marks >= 90)
                return "A";
            else if (marks >= 80)
                return "B";
            else if (marks >= 70)
                return "C";
            else if (marks >= 60)
                return "D";
            else
                return "F";
        }

        public void Display()
        {
            Console.WriteLine("Student Roll Number : " + roll);
            Console.WriteLine("Student Name : " + name);
            Console.WriteLine("Student Marks : " + marks);
            Console.WriteLine("Student Grade : " + CalculateGrade());
        }
    }

    class Program29
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Console.WriteLine("Student Information (Default Con.) : ");
            s1.Display();

            Student s2 = new Student();
            Console.WriteLine("Student Information (Parameterized Con.) : ");
            s2.Display();
        }
    }
}
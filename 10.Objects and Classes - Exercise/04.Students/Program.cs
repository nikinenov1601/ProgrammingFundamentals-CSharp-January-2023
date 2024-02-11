using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double Grade { get; set; }

    public override string ToString()
    {
        return $"{FirstName} {LastName}: {Grade:F2}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<Student> students = new List<Student>();

        for (int i = 0; i < n; i++)
        {
            string[] studentInfo = Console.ReadLine().Split();
            string firstName = studentInfo[0];
            string lastName = studentInfo[1];
            double grade = double.Parse(studentInfo[2]);

            students.Add(new Student { FirstName = firstName, LastName = lastName, Grade = grade });
        }

        students = students.OrderByDescending(s => s.Grade).ToList();

        foreach (Student student in students)
        {
            Console.WriteLine(student);
        }
    }
}

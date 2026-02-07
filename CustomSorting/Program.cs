
using System;
using System.Collections.Generic;

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int Marks { get; set; }
}

class StudentComparer : IComparer<Student>
{
    public int Compare(Student x, Student y)
    {
        if (x.Marks != y.Marks)
        {
            return y.Marks.CompareTo(x.Marks); // Higher marks first
        }

        return x.Age.CompareTo(y.Age); // Younger age first
    }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student { Name = "Amit", Age = 22, Marks = 85 },
            new Student { Name = "Neha", Age = 20, Marks = 90 },
            new Student { Name = "Rahul", Age = 21, Marks = 90 },
            new Student { Name = "Priya", Age = 23, Marks = 85 }
        };

        students.Sort(new StudentComparer());

        Console.WriteLine("Sorted Student List:");
        foreach (var s in students)
        {
            Console.WriteLine($"{s.Name} - Age: {s.Age}, Marks: {s.Marks}");
        }
    }
}

using System;
using System.Collections.Generic;

// Student class
public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int Marks { get; set; }

    public override string ToString()
    {
        return $"{Name} | Age: {Age} | Marks: {Marks}";
    }
}

// Custom comparer
public class StudentComparer : IComparer<Student>
{
    public int Compare(Student x, Student y)
    {
        // Sort by Marks (Descending)
        int marksCompare = y.Marks.CompareTo(x.Marks);
        if (marksCompare != 0)
            return marksCompare;

        // If Marks equal → Sort by Age (Ascending)
        return x.Age.CompareTo(y.Age);
    }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student { Name = "Akash", Age = 22, Marks = 90 },
            new Student { Name = "Ravi", Age = 20, Marks = 90 },
            new Student { Name = "Neha", Age = 21, Marks = 85 },
            new Student { Name = "Pooja", Age = 19, Marks = 95 }
        };

        students.Sort(new StudentComparer());

        foreach (Student student in students)
        {
            Console.WriteLine(student);
        }
    }
}

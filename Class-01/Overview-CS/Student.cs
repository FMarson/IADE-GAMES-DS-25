using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string Name { get; private set; }
    public int Age { get; private set; }
    private readonly List<double> _grades = new();

    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void AddGrade(double grade)
    {
        if (grade < 0 || grade > 10)
        {
            Console.WriteLine("Invalid grade (0 to 10).");
            return;
        }
        _grades.Add(grade);
    }

    public double Average => _grades.Count == 0 ? 0 : _grades.Average();

    public void ShowInfo()
    {
        Console.WriteLine($"Student: {Name} ({Age} years) | Grades: {string.Join(", ", _grades)} | Average: {Average:F2}");
    }
}

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== C# Basic Demonstration ===");

        // Primitive types and type inference
        int age = 20;
        double height = 1.75;
        decimal salary = 3500.50m;
        bool active = true;
        char initial = 'A';
        string name = "Ana";
        DateTime today = DateTime.Now;
        var message = "Inferred as string";

        Console.WriteLine($"Name: {name}, Age: {age}, Height: {height}, Salary: {salary}, Active: {active}, Initial: {initial}, Today: {today}, Msg: {message}");

        // User input
        Console.Write("Enter an integer number: ");
        string numberInput = Console.ReadLine();
        if (!int.TryParse(numberInput, out int number))
        {
            Console.WriteLine("Invalid value. Using 0.");
            number = 0;
        }

        // If/else conditional
        if (number > 10)
            Console.WriteLine("Number greater than 10");
        else if (number == 10)
            Console.WriteLine("Number is 10");
        else
            Console.WriteLine("Number less than 10");

        // Switch with enum
        CourseLevel level = CourseLevel.Beginner;
        switch (level)
        {
            case CourseLevel.Beginner:
                Console.WriteLine("Level: Beginner");
                break;
            case CourseLevel.Intermediate:
                Console.WriteLine("Level: Intermediate");
                break;
            case CourseLevel.Advanced:
                Console.WriteLine("Level: Advanced");
                break;
        }

        // Arrays and List
        int[] numbers = { 1, 2, 3, 4 };
        List<string> languages = new List<string> { "C#", "Java", "Python" };

        Console.WriteLine("Array with for:");
        for (int i = 0; i < numbers.Length; i++)
            Console.Write(numbers[i] + " ");
        Console.WriteLine();

        Console.WriteLine("List with foreach:");
        foreach (var lang in languages)
            Console.WriteLine(lang);

        // While
        int counter = 3;
        while (counter > 0)
        {
            Console.WriteLine($"Count: {counter}");
            counter--;
        }

        // Do While
        int x = 0;
        do
        {
            Console.WriteLine("Executes at least once");
            x++;
        } while (x < 1);

        // Using Student class
        Student student = new Student("Ana", 20);
        student.AddGrade(8.5);
        student.AddGrade(9.2);
        student.ShowInfo();

        // Static method
        int sum = MathHelper.Add(5, 7);
        Console.WriteLine($"Sum 5 + 7 = {sum}");

        Console.WriteLine("End. Press ENTER to exit.");
        Console.ReadLine();
    }
}

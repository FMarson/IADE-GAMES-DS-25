// Write a program with a function that receives a number and prints
// that number minus 1 on the screen repeatedly until it reaches 0.

using System;

void IterativeCountdown(int n) {
    for (int i = n; i >= 0; i--) {
        Console.Write(i + " ");
    }
}

void RecursiveCountdown(int n) {
    if (n < 0) return; // base case: if n is less than 0, stop the recursion
    Console.Write(n + " "); // print the current number
    RecursiveCountdown(n - 1); // recursive case: call Countdown with n-1
}

Console.Write("Enter a number: ");
string input = Console.ReadLine() ?? "0";
if (int.TryParse(input, out int number)) {
    Console.WriteLine("Iterative Countdown:");
    IterativeCountdown(number);
    Console.WriteLine("\n1Recursive Countdown:");
    RecursiveCountdown(number);
} else {
    Console.WriteLine("Invalid input. Please enter a valid integer.");
}   




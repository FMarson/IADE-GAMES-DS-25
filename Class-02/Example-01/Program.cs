using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

void IterativeCountdown(int n) {
    for (int i = n; i >= 0; i--) {
        Console.Write(i + " ");
    }
}

void RecursiveCountdown(int n) {
    Console.Write(n + " ");
    if(n > 0)
        RecursiveCountdown(n - 1);
}

int pow(int x, int y)
{
    if (y == 0)
        return 1; // stop
    else
        return (x * pow(x, y - 1)); // recursive call
}


Console.Write(pow(2, 3)); // 8

/*
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
*/



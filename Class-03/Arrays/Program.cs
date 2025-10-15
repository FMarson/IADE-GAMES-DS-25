using System;

// Demonstrates 1D, 2D, 3D, and jagged arrays in C#

// 1D array example from initialization

int[] primes = new int[] { 2, 3, 5, 7, 11, 13 };
string[] fruits = new string[] { "apple", "banana", "cherry" };


Console.WriteLine("1D Array from Initialization:\n");
for (int i = 0; i < primes.Length; i++) {
    Console.WriteLine($"primes[{i}] = {primes[i]}");
}

for (int i = 0; i < fruits.Length; i++) {
    Console.WriteLine($"fruits[{i}] = {fruits[i]}");
}


// 1D array example reading from console

Console.WriteLine("1D Array Example:\n");

int size = 6;

int[] numbers = new int[size]; 
string[] words = new string[size];

for (int i = 0; i < size; i++) {
    Console.Write($"Enter integer for numbers[{i}]: ");
    numbers[i] = int.Parse(Console.ReadLine() ?? "1");
}

for (int i = 0; i < size; i++) {
    Console.Write($"Enter string for words[{i}]: "); 
    words[i] = Console.ReadLine() ?? string.Empty;
}

for (int i = 0; i < numbers.Length; i++) {
    Console.WriteLine($"numbers[{i}] = {numbers[i]}");
}

for (int i = 0; i < words.Length; i++) {
    Console.WriteLine($"words[{i}] = {words[i]}");
}

// 2D array example
Console.WriteLine("2D Array Example:\n");

int rows = 4; 
int cols = 6; 
var rnd = new Random(); 

int[,] matrix = new int[rows, cols];

for (int r = 0; r < rows; r++)
{
    for (int c = 0; c < cols; c++)
    {
        matrix[r, c] = rnd.Next(0, 100);
    }
}

for (int r = 0; r < rows; r++)
{
    for (int c = 0; c < cols; c++)
    {
        Console.Write(matrix[r, c].ToString().PadLeft(4));
    } 
    Console.WriteLine();
}

// 3D array example
Console.WriteLine("3D Array Example:\n");

int depth = 3;
int[,,] cube = new int[rows, cols, depth];
for (int r = 0; r < rows; r++)
{
    for (int c = 0; c < cols; c++)
    {
        for (int d = 0; d < depth; d++)
        {
            cube[r, c, d] = rnd.Next(0, 100);
        }
    }
} 
for (int d = 0; d < depth; d++)
{
    Console.WriteLine($"Depth {d}:");
    for (int r = 0; r < rows; r++)
    {
        for (int c = 0; c < cols; c++)
        {
            Console.Write(cube[r, c, d].ToString().PadLeft(4));
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Jagged array example
Console.WriteLine("Jagged Array Example:\n");

int jaggedRows = 4;
int[][] jaggedArray = new int[jaggedRows][];
for (int r = 0; r < jaggedRows; r++)
{
    int jaggedCols = rnd.Next(1, 7); 
    jaggedArray[r] = new int[jaggedCols];
    for (int c = 0; c < jaggedCols; c++)
    {
        jaggedArray[r][c] = rnd.Next(0, 100);
    }
}

// Print jagged array
for (int r = 0; r < jaggedRows; r++)
{
    for (int c = 0; c < jaggedArray[r].Length; c++)
    {
        Console.Write(jaggedArray[r][c].ToString().PadLeft(4));
    }
    Console.WriteLine();
}


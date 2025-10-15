using System;

// Demonstrates basic List<T> in C#
using System.Collections.Generic;
using System.Linq;

// 1D List example from initialization
List<int> primes = new List<int> { 2, 3, 5, 7, 11, 13 };
List<string> fruits = new List<string> { "apple", "banana", "cherry" };

Console.WriteLine("1D List from Initialization:\n");
for (int i = 0; i < primes.Count; i++) {
    Console.WriteLine($"primes[{i}] = {primes[i]}");
}

for (int i = 0; i < fruits.Count; i++) {
    Console.WriteLine($"fruits[{i}] = {fruits[i]}");
}
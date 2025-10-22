using System;
using System.IO;

string path = "example.txt";
string[] lines = { "First line", "Second line", "Third line" };

System.IO.File.WriteAllLines(path, lines);
Console.WriteLine("Lines written to file.");

string[] readLines = System.IO.File.ReadAllLines(path);

Console.WriteLine("Lines read from file:");

foreach (string line in readLines)
{
    Console.WriteLine(line);
}
Random rnd = new Random();
System.IO.File.Delete(path);

pair<int, string> p1 = new pair<int, string>(1, "One");
  
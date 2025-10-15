using System;

int[] numbers;

Random rand = new Random();

numbers = new int[10];

//creating random numbers between 10 and 90
for (int i = 0; i < numbers.Length; i++){
    numbers[i] = rand.Next(10, 91);
}

//a
bool found = false;
foreach (int number in numbers){
    if(number == 50){
        Console.WriteLine("Found 50!");
        found = true;
        break;
    }
}
if(!found){
    Console.WriteLine("50 not found.");
}

//b
int count50 = 0;
foreach (int number in numbers)
    if (number == 50)
        count50++;
Console.WriteLine($"50 appears {count50} times.");


//c
float average = 0.0f;
foreach (int number in numbers)
    average += number;
average /= numbers.Length;
Console.WriteLine($"Average: {average}");

//d
int min, max;
min = max = numbers[0];

for (int i = 1; i < numbers.Length; i++)
    if (numbers[i] < min)
        min = numbers[i];
    else if (numbers[i] > max)
        max = numbers[i];

//e
long sum, product;
sum = 0;
product = 1;    
foreach (int number in numbers){
    sum += number;
    product *= number;
}

//f
for (int i = numbers.Length - 1; i >= 0; i--)
    Console.Write(numbers[i] + " ");

//g
int[] reverseNumbers = new int[numbers.Length];
for (int i = 0, j = numbers.Length -1; i < numbers.Length; i++, j--)
    reverseNumbers[i] = numbers[j];

//h
int evenCount = 0, oddCount = 0;
foreach (int number in numbers)
    if (number % 2 == 0)
        evenCount++;
    else
        oddCount++;
int[] evenNumbers = new int[evenCount];
int[] oddNumbers = new int[oddCount];
evenCount = oddCount = 0;
foreach (int number in numbers)
    if (number % 2 == 0)
        evenNumbers[evenCount++] = number;
    else
        oddNumbers[oddCount++] = number;

int fernando = 10;
Console.WriteLine(fernando++); // prints 10     
Console.WriteLine(++fernando); // prints 12 
Console.WriteLine(--fernando); // prints 11
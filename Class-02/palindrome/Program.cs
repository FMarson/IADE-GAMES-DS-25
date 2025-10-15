using System;
using System.Text;

// Normalize the string by removing non-alphanumeric characters and converting to lowercase
static string Normalize(string s) {
    var sb = new StringBuilder(s.Length);
    foreach (char c in s) {
        if (char.IsLetterOrDigit(c))
            sb.Append(char.ToLowerInvariant(c));
    }
    return sb.ToString();
}

// Recursive function to check if a string is a palindrome
static bool IsPalindromeRecursive(string s, int left, int right) {
    /* base cases and recursive case
        - base case 1: if we've checked all characters, is a palindrome
        - base case 2: if characters at left and right don't match, isn't a palindrome
        OK - recursive case: check next pair of characters
    */

    if (left >= right)
        return true; 
    else if (s[left] == s[right])
        return IsPalindromeRecursive(s, left + 1, right - 1);   
    else 
        return false;
}

Console.Write("Enter a word or phrase: ");
string input = Console.ReadLine() ?? string.Empty;

string norm = Normalize(input);
bool result = IsPalindromeRecursive(norm, 0, norm.Length - 1);

if (result)
    Console.WriteLine($"'{input}' is a palindrome.");
else
    Console.WriteLine($"'{input}' is NOT a palindrome.");
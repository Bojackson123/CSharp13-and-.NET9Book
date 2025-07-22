string name = "Samantha Jones";

// Getting the lengths of the first and last names.
int lengthOfFirst = name.IndexOf(' ');
int lengthOfLast = name.Length - lengthOfFirst - 1;

// Using substring.
string firstName = name.Substring(0, lengthOfFirst);

string lastName = name.Substring(name.Length - lengthOfLast, lengthOfLast);

Console.WriteLine($"First: {firstName}, Last: {lastName}");

// Using spans.
ReadOnlySpan<char> nameAsSpan = name.AsSpan();
ReadOnlySpan<char> firstNameSpan = nameAsSpan[0..lengthOfFirst];
ReadOnlySpan<char> lastNameSpan = nameAsSpan[^lengthOfLast..];

Console.WriteLine($"First: {firstNameSpan}, Last: {lastNameSpan}");



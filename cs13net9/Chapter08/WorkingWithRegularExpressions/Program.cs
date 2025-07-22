using System.Text.RegularExpressions;

Console.WriteLine("Enter you age: ");
//string input = Console.ReadLine()!; // Null-forgiving operator.
// Regex ageChecker = new(@"^\d+$");
// Console.WriteLine(ageChecker.IsMatch(input) ? "Thank you!" : $"This is not a valid age: {input}");

// C# 1 to 10: Use escaped double-quote characters \"
// string films = "\"Monsters, Inc.\", \"I, Tonya\",\"Lock, Stock and Two Smoking Barrels\"";

//C# 11 or later: User """ to start and end a raw string literal
string films = """
"Monsters, Inc.","I, Tonya","Lock, Stock and Two Smoking Barrels"
""";

Console.WriteLine($"Films to split: {films}");

string[] filmsDumb = films.Split(',');

Console.WriteLine("Splitting with string.Split method:");
foreach (string film in filmsDumb)
{
    Console.WriteLine($" {film}");
}

Regex csv = new(
    "(?:^|,)(?=[^\"]|(\")?)\"?((?(1)[^\"]*|[^,\"]*))\"?(?=,|$)");

MatchCollection filmsSmart = csv.Matches(films);

Console.WriteLine("Splitting with regular expression:");
foreach (Match film in filmsSmart)
{
    Console.WriteLine($" {film.Groups[2].Value}");
}
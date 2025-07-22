using System.Globalization; // To use CultureInfo.

Console.OutputEncoding = System.Text.Encoding.UTF8; // Enable Euro symbol.

const int width = 40;

string city = "London";
Console.WriteLine($"{city} is {city.Length} characters long");

Console.WriteLine($"First char is {city[0]} and fourth is {city[3]}.");

string cities = "Paris,Tehran,Chennai,Sydney,New York,Medellin";

string[] citiesArray = cities.Split(',');

Console.WriteLine($"There are {citiesArray.Length} items in the array:");

foreach (string item in citiesArray)
{
    Console.WriteLine($" {item}");
}

Console.WriteLine(new string('-', width));

string fullName = "Alan Shore";

int indexOfTheSpace = fullName.IndexOf(' ');

string firstName = fullName.Substring(0, indexOfTheSpace);

string lastName = fullName.Substring(indexOfTheSpace + 1);

Console.WriteLine($"Orginal: {fullName}");
Console.WriteLine($"Swapped: {lastName}, {firstName}");

Console.WriteLine(new string('-', width));

string company = "Microsoft";
Console.WriteLine($"Text: {company}");
Console.WriteLine("Starts with M: {0}, contains an N: {1}",
    arg0: company.StartsWith('M'),
    arg1: company.Contains('N'));

Console.WriteLine(new string('-', width));

CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

string text1 = "Mark";
string text2 = "MARK";

Console.WriteLine($"text1: {text1}, text2: {text2}");

Console.WriteLine($"Compare: {0}: {string.Compare(text1, text2)}");

Console.WriteLine($"Compare (ignoreCase): {string.Compare(text1, text2, ignoreCase: true)}");

Console.WriteLine($"Compare (InvariantCultureIgnoreCase): {string.Compare(text1, text2, StringComparison.InvariantCultureIgnoreCase)}");

// German string comparisions

CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("de-DE");

text1 = "Strasse";
text2 = "Straße";

Console.WriteLine($"text1: {text1}, text2: {text2}");

Console.WriteLine($"Compare: {string.Compare(text1, text2)}");

Console.WriteLine("Compare  (IgnoreCase, IgnoreNonSpace): {0}", string.Compare(text1, text2, CultureInfo.CurrentCulture, CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreCase));

Console.WriteLine("Compare (InvariantCultureIgnoreCase): {0}.",
    string.Compare(text1, text2, StringComparison.InvariantCultureIgnoreCase));

Console.WriteLine(new string('-', width));

string recombined = string.Join(" => ", citiesArray);
Console.WriteLine(recombined);

string fruit = "Apples";
decimal price = 0.39M;
DateTime when = DateTime.Today;

Console.WriteLine($"Interpolated: {fruit} cost {price:C} on {when:dddd}.");
Console.WriteLine(string.Format("string.Format: {0} cost {1:C} on {2:dddd}.",
    arg0: fruit, arg1: price, arg2: when));

Console.WriteLine(new string('-', width));


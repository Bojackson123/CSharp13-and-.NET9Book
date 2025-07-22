using StringDictionary = System.Collections.Generic.Dictionary<string, string>;
using System.Collections.Immutable; // To use ImmutableDictionary
using System.Collections.Frozen;

// Simple syntax for creating a list and adding three items.
List<string> cities = new();
cities.Add("London");
cities.Add("Paris");
cities.Add("Milan");

/* Alternative syntax that is converted by the complier into the three Add method calls above.
List<string> cities = new();
cities.AddRange(new[] {"London", "Paris", "Milan"});  */

OutputCollection("Initial list", cities);
Console.WriteLine($"The first city is {cities[0]}");
Console.WriteLine($"The last city is {cities[cities.Count - 1]}.");
Console.WriteLine($"Are all cities longer than four characters? {
    cities.TrueForAll(city => city.Length > 4)}");
Console.WriteLine($"Do all cities contain the character 'e'? {
    cities.TrueForAll(city => city.Contains('e'))}");

cities.Insert(0, "Sydney");
OutputCollection("After removing two cities", cities);

cities.RemoveAt(1);
cities.Remove("Milan");
OutputCollection("After removing two cities", cities);


// Declare a dictionary without the alias.
// Dictionary<string, string> keywords = new();

// Use the alias to declare the dictionary.
StringDictionary keywords = new();

// Add using named parameters.
keywords.Add(key: "int", value: "32-bit integer data type");

// Add using positional parameters.
keywords.Add("float", "Single percision floating point number");
keywords.Add("long", "64-bit integer data type");

/* Alternitive syntax; complier converts this to calls to Add method.
Dictionary<string, string> keywords = new()
{
    {"int", "32-bit integer data type"},
    {"long", "64-bit integer data type"},
    {"float", "Single percision floating point number"},
}; */

/* Alternitive syntax; complier converts this to calls to Add method.
Dictionary<string, string> keywords = new()
{
    ["int"], "32-bit integer data type",
    ["long"], "64-bit integer data type",
    ["float"], "Single percision floating point number",
}; */

OutputCollection("Dicionary keys", keywords.Keys);
OutputCollection("Dictionary values", keywords.Values);

Console.WriteLine("Keywords and their definitions:");
foreach (KeyValuePair<string, string> item in keywords)
{
    Console.WriteLine($" {item.Key}: {item.Value}");
}

// Look up a value using a key.
string key = "long";
Console.WriteLine($"The definition of {key} is {keywords[key]}.");

HashSet<string> names = new();

foreach (string name in new[] {"Adam", "Barry", "Charlie", "Barry"})
{
    bool added = names.Add(name);
    Console.WriteLine($"{name} was added: {added}");
}

Console.WriteLine($"names set: {string.Join(',', names)}.");

Queue<string> coffee = new();

coffee.Enqueue("Damir"); // Front of queue
coffee.Enqueue("Andrea");
coffee.Enqueue("Ronald");
coffee.Enqueue("Amin");
coffee.Enqueue("Irina"); // Back of queue

OutputCollection("Inital queue from front to back", coffee);

// Server handles next person in queue.
string served = coffee.Dequeue();
Console.WriteLine($"Served: {served}");
OutputCollection("Current queue from front to back", coffee);

Console.WriteLine($"{coffee.Peek()} is next in line");
OutputCollection("Current queue from front to back", coffee);


PriorityQueue<string, int> vaccine = new();

// Add some people.
// 1 = High priority people in their 70s or poor health.
// 2 = Medium priority e.g. middle-aged.
// 3 = Low priority e.g. teens and twenties.

vaccine.Enqueue("Pamela", 1);
vaccine.Enqueue("Rebecca", 3);
vaccine.Enqueue("Juliet", 2);
vaccine.Enqueue("Ian", 1);

OutputPQ("Current queue for vaccination", vaccine.UnorderedItems);

Console.WriteLine($"{vaccine.Dequeue()} has be vaccinated.");
Console.WriteLine($"{vaccine.Dequeue()} has be vaccinated.");
OutputPQ("Current queue for vaccination", vaccine.UnorderedItems);

Console.WriteLine($"{vaccine.Dequeue()} has been vaccinated.");

Console.WriteLine($"Adding Mark to queue with priority 2.");
vaccine.Enqueue("Mark", 2);

Console.WriteLine($"{vaccine.Peek()} will be next to be vaccinated.");
OutputPQ("Current queue for vaccination", vaccine.UnorderedItems);

// UseDictionary(keywords);
// UseDictionary(keywords.AsReadOnly());
UseDictionary(keywords.ToImmutableDictionary());

ImmutableDictionary<string, string> immutableKeywords = keywords.ToImmutableDictionary();

// Call the add method with a return value.
ImmutableDictionary<string, string> newDictionary = immutableKeywords.Add(
    Guid.NewGuid().ToString(), Guid.NewGuid().ToString());

OutputCollection("Immutable keywords dictionary", immutableKeywords);
OutputCollection("New keywords dictionary", newDictionary);

// Creating a frozen collection has an overhead to perform the sometimes complex optimizations.
FrozenDictionary<string, string> frozenKeywords = keywords.ToFrozenDictionary();

OutputCollection("Frozen keywords dictionary", frozenKeywords);

// Lookups are faster in a frozen dictionary.
Console.WriteLine($"Define long: {frozenKeywords["long"]}");
using Packt.Shared; // To use Person.

ConfigureConsole(); // Sets current culture to US English.
// Alternitives:
// ConfigureConsole(useComputerCulture: true); // Use your culture.
// ConfigureConsole(culture: "fr-FR"); // Use French Culture.


// Person bob = new Person(); // C# 1 or later.
// var bob = new Person(); // C# 3 or later.

Person bob = new(); // C# 9 or later
Console.WriteLine(bob); // Implicit call to ToString().
// Console.WriteLine(bob.ToString()); // Does the same thing.



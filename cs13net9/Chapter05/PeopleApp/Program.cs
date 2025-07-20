using Packt.Shared; // To use Person.
using PacktModern.Shared;
using Fruit = (string Name, int Number); // Aliasing a tuple type.

ConfigureConsole(); // Sets current culture to US English.
// Alternitives:
// ConfigureConsole(useComputerCulture: true); // Use your culture.
// ConfigureConsole(culture: "fr-FR"); // Use French Culture.


// Person bob = new Person(); // C# 1 or later.
// var bob = new Person(); // C# 3 or later.

Person bob = new(); // C# 9 or later
Console.WriteLine(bob); // Implicit call to ToString().
// Console.WriteLine(bob.ToString()); // Does the same thing.

bob.Name = "Bob Smith";

bob.Born = new DateTimeOffset(
  year: 1965, month: 12, day: 22,
  hour: 16, minute: 28, second: 0,
  offset: TimeSpan.FromHours(-5)); // US Eastern Standard Time.

Console.WriteLine(format: "{0} was born on {1:D}.", // Long date.
  arg0: bob.Name, arg1: bob.Born);
Console.WriteLine($"{bob.Name} is a {Person.Species}");
Console.WriteLine($"{bob.Name} was born on {bob.HomePlanet}");

bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;

Console.WriteLine(
  format: "{0}'s favorite wonder is {1}. Its interger is {2}.",
  arg0: bob.Name,
  arg1: bob.FavoriteAncientWonder,
  arg2: (int)bob.FavoriteAncientWonder);

bob.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabylon | WondersOfTheAncientWorld.MausoleumAtHalicarnassus;

Console.WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}.");

// Works with all versions of C#.
Person alfred = new Person();
alfred.Name = "Alfred";
bob.Children.Add(alfred);

// Works with C# 3 and later.
bob.Children.Add(new() { Name = "Bella" });

// Works with C# 9 and later.
bob.Children.Add(new() { Name = "Zoe" });

Console.WriteLine($"{bob.Name} has {bob.Children.Count} children:");

foreach (Person child in bob.Children)
  {
    Console.WriteLine($"{child.Name}");
  }



Person alice = new()
{
  Name = "Alice Jones",
  Born = new(1998, 3, 7, 16, 28, 0, TimeSpan.Zero)
};

Console.WriteLine(format: "{0} was born on {1:d}.", // Short date.
  arg0: alice.Name, arg1: alice.Born);

bob.WriteToConsole();
Console.WriteLine(bob.GetOrgin());
Console.WriteLine(bob.SayHello());
Console.WriteLine(bob.SayHello("Rashid"));
Console.WriteLine(bob.OptionalParameters(3));
Console.WriteLine(bob.OptionalParameters(3, "Jump!", 98.5));
Console.WriteLine(bob.OptionalParameters(3, number: 52.7, command: "Hide!"));

Console.WriteLine("=========================================");

BankAccount.InterestRate = 0.012M; // Store a shared value in static field.

BankAccount jonesAccount = new();
jonesAccount.AccountName = "Mrs. Jones";
jonesAccount.Balance = 2400;
Console.WriteLine(format: "{0} earned {1:C} interest.", 
  arg0: jonesAccount.AccountName,
  arg1: jonesAccount.Balance * BankAccount.InterestRate);

BankAccount gerrierAccount = new();
gerrierAccount.AccountName = "Ms. gerrier";
gerrierAccount.Balance = 98;
Console.WriteLine(format: "{0} earned {1:C} interest.", 
  arg0: gerrierAccount.AccountName,
  arg1: gerrierAccount.Balance * BankAccount.InterestRate);

Console.WriteLine("=========================================");

// Book book = new()
// {
//   Isbn = "978-1803237800",
//   Title = "C# 12 and .NET8 - Modern Cross-Platform Development Fundamentals"
// };

Book book = new(isbn: "978-1803237800", title: "C# 12 and .NET8 - Modern Cross-Platform Development Fundamentals")
  {
    Author = "Mark J. Price",
    PageCount = 821
  };

Console.WriteLine($"{book.Isbn}: {book.Title} written by {book.Author} has {book.PageCount:N0} pages.");

Console.WriteLine("=========================================");

Person blankPerson = new();

Console.WriteLine($"{blankPerson.Name} of {blankPerson.HomePlanet} was created at {blankPerson.Instantiated:hh:mm:ss} on a {blankPerson.Instantiated:dddd}");
Person gunny = new("Gunny", "Mars");
Console.WriteLine("{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}", 
  arg0: gunny.Name,
  arg1: gunny.HomePlanet,
  arg2: gunny.Instantiated);

Console.WriteLine("=========================================");

int a = 10;
int b = 20;
int c = 30;
int d = 40;

Console.WriteLine($"Before: a={a}, b={b}, c={c}, d={d}");

bob.PassingParameters(a, b, ref c, out d);

Console.WriteLine($"After: a={a}, b={b}, c={c}, d={d}");

Console.WriteLine("========================================");
int e = 50;
int f = 60;
int g = 70;
  
Console.WriteLine($"Before: e={e}, f={f}, g={g}, h doesn't exist yet!");

// Simplified C# 7 or later syntax for the out parameter.
bob.PassingParameters(e, f, ref g, out int h);
Console.WriteLine($"Before: e={e}, f={f}, g={g}, h={h}");


Console.WriteLine("=========================================");

bob.ParamsParameters("Sum using commas", 3, 6, 1, 2);
bob.ParamsParameters("Sum using collection expression", [3, 6, 1, 2]);
bob.ParamsParameters("Sum using explicit array",new int[] {3, 6, 1, 2});
bob.ParamsParameters("Sum (empty)");


Console.WriteLine("=========================================");

(string, int) fruit = bob.GetFruit();
Console.WriteLine($"{fruit.Item1}, {fruit.Item2} there are.");
// Without an aliased tuple type
// var fruitNamed = bob.GetNamedFruit();
// With an aliased tuple type. (See using statement at top of file.)
Fruit fruitNamed = bob.GetNamedFruit();
Console.WriteLine($"There are {fruitNamed.Number} {fruitNamed.Name}");

var thing1 = ("Neville", 4);
Console.WriteLine($"{thing1.Item1} has {thing1.Item2} children.");

var thing2 = (bob.Name, bob.Children.Count);
Console.WriteLine($"{thing2.Name} has {thing2.Count} children.");

(string fruitName, int fruitNumber) = bob.GetFruit();
Console.WriteLine($"Deconstructed tuple: {fruitName}, {fruitNumber}");


Console.WriteLine("=========================================");

var (name1, dob1) = bob; // Implicitly calls the Deconstruct method.
Console.WriteLine($"Deconstructed person: {name1}, {dob1}");

var (name2, dob2, fav2) = bob;
Console.WriteLine($"Deconstructed person: {name2}, {dob2}, {fav2}");

Console.WriteLine("=========================================");

// Change to -1 to make the exception handling code execute.
int number = 5;

try
{
  Console.WriteLine($"{number}! is {Person.Factorial(number)}");
}
  catch (Exception ex)
{
  Console.WriteLine($"{ex.GetType()} says: {ex.Message} number was {number}.");
}

Console.WriteLine("=========================================");

Person sam = new()
{
  Name = "Sam",
  Born = new(1969, 6, 25, 0, 0, 0, TimeSpan.Zero)
};

Console.WriteLine(sam.Origin);
Console.WriteLine(sam.Greeting);
Console.WriteLine(sam.Age);

sam.FavoriteIceCream = "Choclate Fudge";
Console.WriteLine($"Sam's favorite ice-cream flavor is {sam.FavoriteIceCream}.");

string color = "Red";

try
{
  sam.FavoritePrimaryColor = color;
  Console.WriteLine($"Sam's favorite primary color is {sam.FavoritePrimaryColor}.");
}
catch (Exception ex)
{
  Console.WriteLine("Tried to set {0} to '{1}': {2}", 
    nameof(sam.FavoritePrimaryColor), color, ex.Message);  
}

sam.Children.Add(new() {Name = "Charlie", Born = new(2010, 3, 18, 0, 0, 0, TimeSpan.Zero)});
sam.Children.Add(new() {Name = "Ella", Born = new(2020, 12, 24, 0, 0, 0, TimeSpan.Zero)});

// Get using children list.
Console.WriteLine($"Sam's first child is {sam.Children[0].Name}");
Console.WriteLine($"Sam's second child is {sam.Children[1].Name}");

// Get using the int indexer.
Console.WriteLine($"Sam's first child is {sam[0].Name}");
Console.WriteLine($"Sam's second child is {sam[1].Name}");

// Get using the string indexer.
Console.WriteLine($"Sam's child name Ella is {sam["Ella"].Age} years old.");

Console.WriteLine("=========================================");

Passenger[] passengers = {
  new FirstClassPassenger {AirMiles = 1_419, Name = "Suman"},
  new FirstClassPassenger {AirMiles = 16_526, Name = "Lucy"},
  new BusinessClassPassenger {Name = "Janice"},
  new CoachClassPassenger {CarryOnKG = 25.7, Name = "Dave"},
  new CoachClassPassenger {CarryOnKG = 0, Name = "Amit"}
};

foreach (Passenger passenger in passengers)
{
    decimal flightCost = passenger switch
    {
      /* C# 8 syntax
      FirstClassPassenger p when p.AirMiles > 35_000 => 1_500M,
      FirstClassPassenger p when p.AirMiles > 15_000 => 1_750M,
      FirstClassPassenger _                          => 2_000M,*/

      // C# 9 or later syntax.
      FirstClassPassenger p => p.AirMiles switch
      {
        > 35_000 => 1_500M,
        > 15_000 => 1_750M,
        _        => 2_000M
      },
      
      BusinessClassPassenger _                       => 1_000M,
      CoachClassPassenger p when p.CarryOnKG < 10.0  => 500M,
      CoachClassPassenger _                          => 600M,
      _                                              => 800M
    };
    Console.WriteLine($"Flight costs {flightCost:C} for {passenger}");
}



Console.WriteLine("=========================================");

ImmutablePerson jeff = new() {FirstName = "Jeff", LastName = "Winger"};
// jeff.FirstName = "Geoff"; // Throws error
ImmutableVehicle car = new() {Brand = "Mazda MX-5 RF", Color = "Soul Red Crystal Metallic", Wheels = 4};

ImmutableVehicle repaintedCar = car with {Color = "Polymetal Grey Metallic"};

Console.WriteLine($"Original car color was {car.Color}.");
Console.WriteLine($"New car color is {repaintedCar.Color}.");

AnimalClass ac1 = new() {Name = "Rex"};
AnimalClass ac2 = new() {Name = "Rex"};

Console.WriteLine($"ac1 == ac2: {ac1 == ac2}");

AnimalRecord ar1 = new() {Name = "Rex"};
AnimalRecord ar2 = new() {Name = "Rex"};

Console.WriteLine($"ar1 == ar2: {ar1 == ar2}");

Console.WriteLine("=========================================");

int number1 = 3;
int number2 = 3;
Console.WriteLine($"number1: {number1}, number2: {number2}");
Console.WriteLine($"number1 == number2: {number1 == number2}");

Person p1 = new() {Name = "Kevin"};
Person p2 = new() {Name = "Kevin"};
Console.WriteLine($"p1: {p1}, p2: {p2}");
Console.WriteLine($"p1.Name: {p1.Name}, p2.Name: {p2.Name}");
Console.WriteLine($"p1 == p2: {p1 == p2}");

Person p3 = p1;
Console.WriteLine($"p3: {p3}");
Console.WriteLine($"p3.Name: {p3.Name}");
Console.WriteLine($"p1 == p3: {p1 == p3}");

// string is the only class reference type implemented to act like a value type for equality.
Console.WriteLine($"p1.Name: {p1.Name}, p2.Name: {p2.Name}");
Console.WriteLine($"p1.Name == p2.Name: {p1.Name == p2.Name}");

ImmutableAnimal oscar = new("Oscar", "Labrador");
var (who, what) = oscar; // calls the deconstructor method.
Console.WriteLine($"{who} is {what}");


Headset vp = new("Apple", "Vision Pro");
Console.WriteLine($"{vp.ProductName} is made by {vp.Manufacturer}");
Headset holo = new();
Console.WriteLine($"{holo.ProductName} is made by {holo.Manufacturer}");

Headset mq = new() {Manufacturer = "Meta", ProductName = "Quest 3"};
Console.WriteLine($"{mq.ProductName} is made by {mq.Manufacturer}");
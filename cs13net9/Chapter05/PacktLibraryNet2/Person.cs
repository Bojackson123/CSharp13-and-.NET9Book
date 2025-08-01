// All types in this file will be defined in this file-scoped namespace.
namespace Packt.Shared;

public partial class Person : object
{
  #region Fields: Data or stat for this person.
  
  public string? Name; // ? means it can be null.
  public DateTimeOffset Born;
  // public WondersOfTheAncientWorld FavoriteAncientWonder; // moved to PersonAutoGen
  public WondersOfTheAncientWorld BucketList;
  public List<Person> Children = new();
  // Constant fields are accessiable via the type. Set at complie time. Must be static.
  public const string Species = "Homo Sapiens";
  // Read-only fields: Values that can be set at runtime. Can be instanced or static.
  public readonly string HomePlanet = "Earth";
  public readonly DateTime Instantiated;
  
  #endregion

  #region Constructors: Called when use new to instantiate a type.

  public Person()
  {
    // Constructors can set default vales for fields
    // including any read-only fields like Instantiated.
    Name = "Unknown";
    Instantiated = DateTime.Now;
  }

  public Person(string initialName, string homePlanet)
  {
    Name = initialName;
    HomePlanet = homePlanet;
    Instantiated = DateTime.Now;
  }
  
  #endregion

  #region Methods: Actions the type can preform.

  public void WriteToConsole()
  {
    Console.WriteLine($"{Name} was born on a {Born:dddd}");
  }

  public string GetOrgin()
  {
    return $"{Name} was born on {HomePlanet}";
  }

  public string SayHello()
  {
    return $"{Name} says 'Hello!'";
  }

  public string SayHello(string name)
  {
    return $"{Name} says 'Hello, {name}!'";
  }

  public string OptionalParameters(int count, string command = "Run!", double number = 0.0, bool active = true)
  {
    return string.Format("Command is {0}, number is {1}, active is {2}",
      arg0: command,
      arg1: number,
      arg2: active);
  }

  public void PassingParameters(int w, in int x, ref int y, out int z)
  {
    // out parameters cannot have a default and they much be initialized inside the method.
    z = 100;

    // Increment each parameter except the read-only x.
    w++;
    // x++; // Gives a complier error!
    y++;
    z++;
    Console.WriteLine($"In the method: w={w}, x={x}, y={y}, z={z}");
  }

  public void ParamsParameters(string text, params int[] numbers)
  {
    int total = 0;

    foreach (int number in numbers)
    {
      total += number;
    }
    Console.WriteLine($"{text}: {total}");
  }

  // Method that returns a tuple: (string, int).
  public (string, int) GetFruit()
  {
    return ("Apples", 5);
  }

  // Method that return a tuple with named fields.
  public (string Name, int Number) GetNamedFruit()
  {
    return ("Apples", 5);
  }

  // Deconstructors: Break down this object into parts.
  public void Deconstruct(out string? name, out DateTimeOffset dob)
  {
    name = Name;
    dob = Born;
  }

  public void Deconstruct(out string? name, out DateTimeOffset dob, out WondersOfTheAncientWorld fav)
  {
    name = Name;
    dob = Born;
    fav = FavoriteAncientWonder;
  }

  // Method with a local function.
  public static int Factorial(int number)
  {
    if (number < 0)
    {
      throw new ArgumentException($"{nameof(number)} cannot be less than zero.");
    }
    return localFactorial(number);

    int localFactorial(int localNumber) // Local function.
    {
      if (localNumber == 0 ) return 1;
      return localNumber * localFactorial(localNumber - 1);
    }
  }
  
  


  #endregion
}
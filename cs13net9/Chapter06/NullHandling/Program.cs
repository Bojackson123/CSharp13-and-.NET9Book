using Packt.Shared;

int thisCannotBeNull = 4;
// thisCannotBeNull = null; // CS0037 complier error!
Console.WriteLine(thisCannotBeNull);

int? thisCouldBeNull = null;

Console.WriteLine(thisCouldBeNull);
Console.WriteLine(thisCouldBeNull.GetValueOrDefault());

thisCouldBeNull = 7;

Console.WriteLine(thisCouldBeNull);
Console.WriteLine(thisCouldBeNull.GetValueOrDefault());

// The actual type of int> is Nullable<int>.
Nullable<int> thisCouldAlsoBeNull = null;
thisCouldAlsoBeNull= 9;
Console.WriteLine(thisCouldAlsoBeNull);

Address address = new(city: "London")
{
    Building = null,
    Street = null!,
    Region = "UK"
};

Console.WriteLine(address.Building?.Length);
if (address.Street is not null)
{
    Console.WriteLine(address.Street.Length);
}


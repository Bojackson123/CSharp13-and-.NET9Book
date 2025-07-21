using System.Numerics; // To use BigInteger

const int width = 40;

Console.WriteLine("ulong.MaxValue vd a 30-digit BigInteger");
Console.WriteLine(new string('-', width));

ulong big = ulong.MaxValue;
Console.WriteLine($"{big,width:N0}");

BigInteger bigger = BigInteger.Parse("123456789012345678901234567890");
Console.WriteLine($"{bigger,width:N0}");

Console.WriteLine(new string('-', width));

Console.WriteLine("Multiplying big integers");
int number1 = 2_000_000_000;
int number2 = 2;
Console.WriteLine($"number1: {number1:N0}");
Console.WriteLine($"number2: {number2:N0}");
Console.WriteLine($"number1 * number2: {number1 * number2:N0}");
Console.WriteLine($"Math.BigMul(number1, number2): {Math.BigMul(number1, number2):N0}");

Console.WriteLine(new string('-', width));

Random r = Random.Shared;

// minValue is an inclusive lower bound i.e. 1 is a possible value.
// maxValue is an exclusive upper bound i.e 7 is not a possible value.
int dieRoll = r.Next(1, 7); // Returns 1 - 6.
Console.WriteLine($"Random die roll: {dieRoll}");

double randomReal = r.NextDouble(); // Returns 0.0 to less than 1.0.
Console.WriteLine($"Random double: {randomReal}");

byte[] arrayOfBytes = new byte[256];
r.NextBytes(arrayOfBytes); // Fills array with 256 random bytes.
Console.Write("Random bytes: ");
for (int i = 0; i < arrayOfBytes.Length; i++)
{
    Console.Write($"{arrayOfBytes[i]:X2} ");
}
Console.WriteLine();

Console.WriteLine(new string('-', width));

string[] beatles = r.GetItems(new[] {"John", "Paul", "George", "Ringo"}, 10);

Console.Write("Random ten beatles:");
foreach (string beatle in beatles)
{
    Console.Write($" {beatle}");
}
Console.WriteLine();

r.Shuffle(beatles);

Console.Write("Shuffled beatles:");
foreach (string beatle in beatles)
{
    Console.Write($" {beatle}");
}
Console.WriteLine();

Console.WriteLine(new string('-', width));

Console.WriteLine($"Empty GUID: {Guid.Empty}.");
Guid g = Guid.NewGuid();
Console.WriteLine($"Random GUID: {g}");

byte[] guidAsBytes = g.ToByteArray();
Console.Write("GUID as byte array: ");
for (int i = 0; i < guidAsBytes.Length; i++)
{
    Console.Write($"{guidAsBytes[i]:X2} ");
}
Console.WriteLine();

Console.WriteLine("Generating three v7 GUIDs:");
for (int i = 0; i < 3; i++)
{
    // Requires DotNet 9+
    // Guid g7 = Guid.CreateVersion7(DateTimeOffset.UtcNow);
    // Console.WriteLine($" {g6}.");
}

Console.WriteLine(new string('-', width));



    

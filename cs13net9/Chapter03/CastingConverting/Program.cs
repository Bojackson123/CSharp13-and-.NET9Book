using static System.Convert;
using System.Globalization;

namespace CastingConverting;

class Program
{
    static void Main(string[] args)
    {
        int a = 10;
        double b = a; // An int can be safely cast into a double.
        Console.WriteLine($"a is {a}, b is {b}");

        double c = 9.8;
        int d = (int)c; // Complier gives an error if you do not explicitly cast. 
        Console.WriteLine($"c is {c}, d is {d}");


        Console.WriteLine("=========================================");

        long e = 5_000_000_000;
        int f = (int)e;
        Console.WriteLine($"e is {e:N0}, f is {f:N0}");

        e = long.MaxValue;
        f = (int)e;
        Console.WriteLine($"e is {e:N0}, f is {f:N0}");


        Console.WriteLine("=========================================");

        Console.WriteLine("{0,12} {1,34}", "Decimal", "Binary");
        Console.WriteLine("{0,12} {0,34:B32}", int.MaxValue);

        for (int i = 8; i>=-8; i--)
        {
            Console.WriteLine("{0,12} {0, 34:B32}", i);
        }
        Console.WriteLine("{0,12} {0,34:B32}", int.MinValue);
        
        Console.WriteLine("=========================================");

        long r = 0b_101000101010001100100111010100101010;
        int s = (int) r;
        Console.WriteLine($"{r,38:B38} = {r}");
        Console.WriteLine($"{s,38:B32} = {s}");
    

        Console.WriteLine("=========================================");

        double g = 9.8;
        int h = ToInt32(g); // A method of System.Convert
        Console.WriteLine($"g is {g}, h is {h}");
        
        Console.WriteLine("=========================================");

        double[,] doubles = 
        {
            {9.49, 9.5, 9.51},
            {10.49, 10.5, 10.51},
            {11.49, 11.5, 11.51},
            {12.49, 12.5, 12.51},
            {-12.49, -12.5, -12.51},
            {-11.49, -11.5, -11.51},
            {-10.49, -10.5, -10.51},
            {-9.49, -9.5, -8.51}
        };

        Console.WriteLine($"| double | ToInt32 | double | ToInt32 | double | ToInt32 |");
        for (int x = 0; x < 8; x++)
        {
            for (int y = 0; y < 3; y++)
            {
                Console.Write($"| {doubles[x, y], 6} | {ToInt32(doubles[x, y]), 7} ");
            }
            Console.WriteLine("|");
        }
        Console.WriteLine();
        
        Console.WriteLine("=========================================");

        foreach (double n in doubles)
        {
            Console.WriteLine(format:
                "Math.Round({0}, 0, MidpointRounding.AwayFromZero) is {1}", 
                arg0: n,
                arg1: Math.Round(n, 0, MidpointRounding.AwayFromZero));
        }

        Console.WriteLine("=========================================");

        int number = 12;
        Console.WriteLine(number.ToString());
        bool boolean = true;
        Console.WriteLine(boolean.ToString());
        DateTime now = DateTime.Now;
        Console.WriteLine(now.ToString());
        object me = new();
        Console.WriteLine(me.ToString());
        
        Console.WriteLine("=========================================");

        // Allocate an array of 128 bytes.
        byte[] binaryObject = new byte[128];

        // Populate the array with random bytes.
        Random.Shared.NextBytes(binaryObject);

        Console.WriteLine("Binary Object as bytes:");
        for (int index = 0; index < binaryObject.Length; index++)
        {
            Console.Write($"{binaryObject[index]:X2} ");
        }
        Console.WriteLine();

        // Convert the array to Base64 string and output as text.
        string encoded = ToBase64String(binaryObject);
        Console.WriteLine($"Binary Object as Base64: {encoded}");

        Console.WriteLine("=========================================");

        // Set the current culture to make sure date parsing works.
        CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

        int friends = int.Parse("27");
        DateTime birthday = DateTime.Parse("4 June 1980");
        Console.WriteLine($"I have {friends} friends to invite to my party.");
        Console.WriteLine($"My birthday is {birthday}.");
        Console.WriteLine($"My birthday is {birthday:D}");

        Console.WriteLine("=========================================");

        Console.Write("How many eggs are there? ");
        string? input = Console.ReadLine();

        if (int.TryParse(input, out int count))
        {
            Console.WriteLine($"There are {count} eggs.");
        }
        else
        {
            Console.WriteLine("I could not parse the input.");
        }
        


        
    }
}

namespace Exercise_Numbers;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine(new string('-', 148));
        Console.WriteLine(format: "{0, -15} {1, -20} {2, 55} {3, 55}",
            "Type","Byte(s) of memory","Min","Max");
        Console.WriteLine(new string('-', 148));

        Console.WriteLine(format: "{0, -15} {1, -20} {2, 55} {3, 55}", "sbyte", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
        Console.WriteLine(format: "{0, -15} {1, -20} {2, 55} {3, 55}", "byte", sizeof(byte), byte.MinValue, byte.MaxValue);
        Console.WriteLine(format: "{0, -15} {1, -20} {2, 55} {3, 55}", "short", sizeof(short), short.MinValue, short.MaxValue);
        Console.WriteLine(format: "{0, -15} {1, -20} {2, 55} {3, 55}", "ushort", sizeof(ushort), ushort.MinValue, ushort.MaxValue);
        Console.WriteLine(format: "{0, -15} {1, -20} {2, 55} {3, 55}", "int", sizeof(int), int.MinValue, int.MaxValue);
        Console.WriteLine(format: "{0, -15} {1, -20} {2, 55} {3, 55}", "long", sizeof(long), long.MinValue, long.MaxValue);
        Console.WriteLine(format: "{0, -15} {1, -20} {2, 55} {3, 55}", "ulong", sizeof(ulong), ulong.MinValue, ulong.MaxValue);
        unsafe
        {
            Console.WriteLine(format: "{0, -15} {1, -20} {2, 55} {3, 55}", "Int128", sizeof(Int128), Int128.MinValue, Int128.MaxValue);
            Console.WriteLine(format: "{0, -15} {1, -20} {2, 55} {3, 55}", "UInt128", sizeof(UInt128), UInt128.MinValue, UInt128.MaxValue);
            Console.WriteLine(format: "{0, -15} {1, -20} {2, 55} {3, 55}", "Half", sizeof(Half), Half.MinValue, Half.MaxValue);
        }
        Console.WriteLine(format: "{0, -15} {1, -20} {2, 55} {3, 55}", "floar", sizeof(float), float.MinValue, float.MaxValue);
        Console.WriteLine(format: "{0, -15} {1, -20} {2, 55} {3, 55}", "double", sizeof(double), double.MinValue, double.MaxValue);
        Console.WriteLine(format: "{0, -15} {1, -20} {2, 55} {3, 55}", "decimal", sizeof(decimal), decimal.MinValue, decimal.MaxValue);
        Console.WriteLine();
        Console.WriteLine(new string('-', 148));
    }
}

﻿namespace Numbers;

class Program
{
    static void Main(string[] args)
    {
        // An unsigned interger is a positive whole number or 0.
        // unit naturalNumber = 23;
        // An interger is a negative or positive whole number or 0.
        int intergerNumber = -23;

        // A float is a single-percision floating-point number.
        // double is the default for a number value with a decimal point.
        double anotherRealNumber = 2.3; // A double literal value.

        int decimalNotation = 2_000_000;
        int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
        int hexadecimalNotation = 0x_001E_8480;

        // Check the three variables have the same value.
        Console.WriteLine($"{decimalNotation == binaryNotation}");
        Console.WriteLine($"{decimalNotation == hexadecimalNotation}");

        // Output the variable in decimal values. 
        Console.WriteLine($"{decimalNotation:N0}");
        Console.WriteLine($"{binaryNotation:N0}");
        Console.WriteLine($"{hexadecimalNotation:N0}");
        
        // Output the variable values in hexadecimal.
        Console.WriteLine($"{decimalNotation:X}");
        Console.WriteLine($"{binaryNotation:X}");
        Console.WriteLine($"{hexadecimalNotation:X}");

        Console.WriteLine("==========================================");

        Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue:N0} to {int.MaxValue:N0}.");
        Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range {double.MinValue:N0} to {double.MaxValue:N0}.");
        Console.WriteLine($"decimal uses {sizeof(double)} bytes and can store numbers in the range {decimal.MinValue:N0} to {decimal.MaxValue:N0}");

        Console.WriteLine("==========================================");


        Console.WriteLine("Using Doubles:");
        double a = 0.1;
        double b = 0.2;
        if (a + b == 0.3)
        {
            Console.WriteLine($"{a} + {b} equals {0.3}");
        }
        else
        {
            Console.WriteLine($"{a} + {b} does NOT equal {0.3}");
        }

        Console.WriteLine("Using Decimals:");
        decimal c = 0.1M;
        decimal d = 0.2M;
        if (c + d == 0.3M)
        {
            Console.WriteLine($"{c} + {d} equals {0.3}");
        }
        else
        {
            Console.WriteLine($"{c} + {d} does NOT equal {0.3}");
        }


        Console.WriteLine("==========================================");

        #region Special float and double values

        Console.WriteLine($"double.Epsilon: {double.Epsilon}");
        Console.WriteLine($"double.Epsilon to 324 decimal places: {double.Epsilon:N324}");
        Console.WriteLine($"double.Epsilon to 330 decimal places: {double.Epsilon:N330}");

        const int col1 = 37; // First column width.
        const int col2 = 6; // Second column width.
        string line = new string('-', col1 + col2 + 3);

        Console.WriteLine(line);
        Console.WriteLine($"{"Expression", -col1} | {"Value", col2}");
        Console.WriteLine(line);
        Console.WriteLine($"{"double.NaN", -col1} | {double.NaN, col2}");
        Console.WriteLine($"{"double.PositiveInfinity", -col1} | {double.PositiveInfinity, col2}");
        Console.WriteLine($"{"double.NegativeInfinity", -col1} | {double.NegativeInfinity, col2}");
        Console.WriteLine(line);
        Console.WriteLine($"{"0.0 / 0.0", -col1} | {0.0 / 0.0, col2}");
        Console.WriteLine($"{"3.0 / 0.0", -col1} | {3.0 / 0.0, col2}");
        Console.WriteLine($"{"-3.0 / 0.0", -col1} | {-3.0 / 0.0, col2}");
        Console.WriteLine($"{"3.0 / 0.0 == double.PositiveInfinity", -col1} | {3.0 / 0.0 == double.PositiveInfinity, col2}");
        Console.WriteLine($"{"-3.0 / 0.0 == double.NegativeInfinity", -col1} | {-3.0 / 0.0 == double.NegativeInfinity, col2}");
        Console.WriteLine($"{"0.0 / 3.0", -col1} | {0.0 / 3.0, col2}");
        Console.WriteLine($"{"0.0 / -3.0", -col1} | {0.0 / -3.0, col2}");

        #endregion

        Console.WriteLine("==========================================");
        unsafe
        {
            Console.WriteLine($"Half uses {sizeof(Half)} bytes and can store numbers in range {Half.MinValue:N0} to {Half.MaxValue:N0}.");
            Console.WriteLine($"Int128 uses {sizeof(Int128)} bytes and can store numbers in range {Int128.MinValue:N0} to {Int128.MaxValue}.");
        }

        Console.WriteLine("==========================================");

        
    }
}

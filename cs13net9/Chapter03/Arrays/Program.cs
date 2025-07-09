namespace Arrays;

class Program
{
    static void Main(string[] args)
    {
        string[] names; // This is refrence any size array of strings.

        // Allocate memory for four strings in an array.
        names = new string[4];

        // Store items at these index positions.
        names[0] = "Kate";
        names[1] = "Jack";
        names[2] = "Rebecca";
        names[3] = "Tom";

        string[] names2 = new string[] {"Kate", "Jack", "Rebecca", "Tom"};

        // Loop through the names.
        for (int i = 0; i < names2.Length; i++)
        {
            // Output the item at index position i.
            Console.WriteLine($"{names[i]} is at position {i}");
        }

        string[,] grid1 = // Two dimensional array.
        {
            {"Alpha", "Beta", "Gamma", "Delta"},
            {"Anne", "Ben", "Charlie", "Doug"},
            {"Aardvark", "Bear", "Cat", "Dog"}
        };

        Console.WriteLine($"1st dimension, lower bound: {grid1.GetLowerBound(0)}");
        Console.WriteLine($"1st dimension, upper bound: {grid1.GetUpperBound(0)}");
        Console.WriteLine($"2nd dimension, lower bound: {grid1.GetLowerBound(1)}");
        Console.WriteLine($"2nd dimension, upper bound: {grid1.GetUpperBound(1)}");

        for (int row = 0; row <= grid1.GetUpperBound(0); row++)
        {
            for (int col = 0; col <= grid1.GetUpperBound(1); col++)
            {
                Console.WriteLine($"Row {row}, Column {col}: {grid1[row, col]}");
            }
        }

        string[][] jagged = // An Array of string arrays
        {
            new[] {"Alpha", "Beta", "Gamma"},
            new[] {"Anne", "Ben", "Charlie", "Doug"},
            new[] {"Aardvark", "Bear"}
        };

        Console.WriteLine($"Upper bound of the array of arrays is: {0}",
            jagged.GetUpperBound(0));

        for (int array = 0; array <= jagged.GetUpperBound(0); array++)
        {
            Console.WriteLine($"Upper bound of array {0} is: {1}",
                arg0: array, 
                arg1: jagged[array].GetUpperBound(0));
        }
    }
}

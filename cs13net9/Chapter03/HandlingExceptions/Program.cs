namespace HandlingExceptions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Before parsing");
        Console.Write("What is your age? ");
        string? input = Console.ReadLine();

        try
        {
            int age = int.Parse(input!);
            Console.WriteLine($"You are {age} years old.");
        }
        catch (FormatException)
        {
            Console.WriteLine("The age you entered is not a valid number format.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Your age is a valid number format but it is either too big or too small.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"{ex.GetType()} says {ex.Message}");
        }
        Console.WriteLine("After parsing");

        Console.WriteLine("=========================================");

        Console.WriteLine("Without 'Checked'");
        int x = int.MaxValue - 1;
        Console.WriteLine($"Initial value: {x}");
        x++;
        Console.WriteLine($"After incrementing: {x}");
        x++;
        Console.WriteLine($"After incrementing: {x}");
        x++;
        Console.WriteLine($"After incrementing: {x}");

        Console.WriteLine("With 'Checked' and 'TryCatch'");
        try
        {
            checked
            {
                x = int.MaxValue - 1;
                Console.WriteLine($"Initial value: {x}");
                x++;
                Console.WriteLine($"After incrementing: {x}");
                x++;
                Console.WriteLine($"After incrementing: {x}");
                x++;
                Console.WriteLine($"After incrementing: {x}");
            }
        }
        catch
        {
            Console.WriteLine("The code overflowed but I caught the exception");
        }
        

        Console.WriteLine("=========================================");

        unchecked
        {
            int y = int.MaxValue + 1;
            Console.WriteLine($"Initial value: {y}");
            y--;
            Console.WriteLine($"After decrementing: {y}");
            y--;
            Console.WriteLine($"After decrementing: {y}");
        }
        

        Console.WriteLine("=========================================");
    }
}

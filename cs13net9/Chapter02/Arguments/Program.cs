namespace Arguments;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"There are {args.Length} arguments.");

        foreach (string arg in args)
        {
            Console.WriteLine(arg);
        }

        if (args.Length < 3)
        {
            Console.WriteLine("You must specify two colors and cursor size, e.g.");
            Console.WriteLine("dotnet run red yellow 50");
            return; // stop running.
        }

        Console.ForegroundColor = (ConsoleColor)Enum.Parse(
            enumType: typeof(ConsoleColor),
            value: args[0], ignoreCase: true);

        Console.BackgroundColor = (ConsoleColor)Enum.Parse(
        enumType: typeof(ConsoleColor),
        value: args[1], ignoreCase: true);

        try
        {
            Console.CursorSize = int.Parse(args[2]);
        }
        catch (PlatformNotSupportedException)
        {
            Console.WriteLine("The current platform does not support changing the size of the cursor.");    
        }
        
    }
}

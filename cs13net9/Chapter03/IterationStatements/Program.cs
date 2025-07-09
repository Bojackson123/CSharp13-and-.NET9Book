namespace IterationStatements;

class Program
{
    static void Main(string[] args)
    {
        int x = 0;
        while (x < 10)
        {
            Console.WriteLine(x);
            x++;
        }

        // string? actualPassword = "Pa$$w0rd";
        // string? password;

        // do
        // {
        //     Console.Write("Enter your password: ");
        //     password = Console.ReadLine();
        // }
        // while (password != actualPassword);

        // Console.WriteLine("Correct");

        for (int y = 0; y <= 10; y++)
        {
            Console.WriteLine(y);
        }

        for (int y = 0; y <= 10; y += 3)
        {
            Console.WriteLine(y);
        }

        string[] names = {"Adam", "Barry", "Charlie"};
        foreach (string name in names)
        {
            Console.WriteLine($"{name} has {name.Length} characters.");
        }
    }
}

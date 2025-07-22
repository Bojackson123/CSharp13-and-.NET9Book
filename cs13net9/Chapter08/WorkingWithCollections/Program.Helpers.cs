partial class Program
{
    private static void OutputCollection<T>(string title, IEnumerable<T> collection)
    {
        Console.WriteLine($"{title}:");
        foreach (T item in collection)
        {
            Console.WriteLine($" {item}");
        }
    }

    private static void OutputPQ<TElement, TPriority>(string title, 
        IEnumerable<(TElement Element, TPriority Priority)> collection)
    {
        Console.WriteLine($"{title}:");
        foreach ((TElement, TPriority) item in collection)
        {
            Console.WriteLine($" {item.Item1}: {item.Item2}");
        }
    }

    private static void UseDictionary(IDictionary<string, string> dictionary)
    {
        Console.WriteLine($"Count before is {dictionary.Count}");
        try
        {
            Console.WriteLine("Adding new item with GUID values.");
            // Add method with return type of void.
            dictionary.Add(Guid.NewGuid().ToString(), Guid.NewGuid().ToString());
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("This dictionary does not support the Add method.");
        }
        Console.WriteLine($"Count after is {dictionary.Count}");
    }
}
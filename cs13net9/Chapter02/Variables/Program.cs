namespace Variables;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        object height = 1.88; // Storing a double in an object.
        object name = "Amir"; // Storing a string in an object.
        Console.WriteLine($"{name} is {height} metres tall.");

        // int length1 = name.Length; // This gives a complie error!
        int length2 = ((string)name).Length; // Case name to a string.
        Console.WriteLine($"{name} has {length2} characters.");

        Console.WriteLine("==================================");

        dynamic something;

        // Storing an arrya of int values in a dynamic object.
        // An array of any type has a Length property.
        something = new[] {3, 5, 6};
        // Storing an int in a dynamic object.
        // int does not have a Length property.
        // something = 12;

        // Storing a string in a dynamic object.
        // string has a Length property.
        // something = "Ahmed";

        // This complies but might throw an exception at run-time.
        Console.WriteLine($"The length of something is {something.Length}");

        // Output the type of the something variable.
        Console.WriteLine($"something is a {something.GetType()}");

        Console.WriteLine("==================================");

        // int population = 67_000_000; // 67 million in UK.
        // double weight = 1.88; // in kilograms.
        // decimal price = 4.99m; // in pounds sterling.
        // string fruit = "Apples"; // string values use double-quotes.
        // char letter = "z"; // char values use single-quotes.
        // bool happy = true; // Booleans can only be true or false.

        var population = 67_000_000; // 67 million in UK.
        var weight = 1.88; // in kilograms.
        var price = 4.99m; // in pounds sterling.
        var fruit = "Apples"; // string values use double-quotes.
        var letter = 'z'; // char values use single-quotes.
        var happy = true; // Booleans can only be true or false.

        // Good use of car becasue it avoids repeated type
        // as show in the more verbose second statment.
        var xml1 = new XmlDocument(); // Works with C# 3 and later.
        XmlDocument xml2 = new XmlDocument(); // Works with all C# versions.

        // Bad use of var because we cannot tell the type, so we 
        // should use a specific type declaration as shown in 
        // the second statement.
        var file1 = File.CreateText("something1.txt");
        StreamWriter file2 = File.CreateText("something2.txt");

        Console.WriteLine("==================================");

        Console.WriteLine($"default(int) = {default(int)}");
        Console.WriteLine($"default(bool) = {default(bool)}");
        Console.WriteLine($"default(DateTime) = {default(DateTime)}");
        Console.WriteLine($"default(string) = {default(string) ?? "<NULL>"}");
    }    
}

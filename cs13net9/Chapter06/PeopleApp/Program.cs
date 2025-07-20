using Packt.Shared;
using System.Collections;

namespace PeopleApp;

partial class Program
{
    static void Main(string[] args)
    {
        Person harry = new()
        {
            Name = "Harry",
            Born = new(2001, 3, 25, 0, 0, 0, TimeSpan.Zero)
        };

        harry.WriteToConsole();

        Console.WriteLine("==================================");

        // Implementing functionality using methods.
        Person lamech = new() {Name = "Lamech"};
        Person adah = new() {Name = "Adah"};
        Person zillah = new() {Name = "Zillah"};

        // Call the instance method to marry Lamech and Adah.
        lamech.Marry(adah);

        // Call the static method to marry Lamech and Zillah.
        // Person.Marry(lamech, zillah);
        if (lamech + zillah)
        {
            Console.WriteLine($"{lamech.Name} and {zillah.Name} successfully got married.");
        }

        lamech.OutputSpouses();
        adah.OutputSpouses();
        zillah.OutputSpouses();

        // Call the instance method to make a baby.
        Person baby1 = lamech.ProcreateWith(adah);
        baby1.Name = "Jabal";
        Console.WriteLine($"{baby1.Name} was born on {baby1.Born}");

        // Call the static method to make a baby.
        Person baby2 = Person.Procreate(zillah, lamech);
        baby2.Name = "Tubalcain";

        // Use the * operator to "multiply".
        Person baby3 = lamech * adah;
        baby3.Name = "Jubal";

        Person baby4 = zillah * lamech;
        baby4.Name = "Naamah";
        
        adah.WriteChildrenToConsole();
        zillah.WriteChildrenToConsole();
        lamech.WriteChildrenToConsole();

        for (int i = 0; i < lamech.Children.Count; i++)
        {
            Console.WriteLine(" {0}'s child #{1} is named \"{2}\".",
                arg0: lamech.Name, arg1: i, arg2: lamech.Children[i].Name);
        }

        Console.WriteLine("==================================");

        // Non-generic lookip Collection
        Hashtable lookupObject = new();
        lookupObject.Add(1, "Alpha");
        lookupObject.Add(2, "Beta");
        lookupObject.Add(3, "Gamma");
        lookupObject.Add(harry, "Delta");

        int key = 2; // Loop up the value that has

        Console.WriteLine($"Key {key} has a value: {lookupObject[key]}");

        //Look up the value that has harry as the key.
        Console.WriteLine($"Key {key} has value: {lookupObject[harry]}");

        // Define generic lookup collection.
        Dictionary<int, string> lookupIntString = new();
        lookupIntString.Add(1, "Alpha");
        lookupIntString.Add(2, "Beta");
        lookupIntString.Add(3, "Gamma");
        lookupIntString.Add(4, "Delta");

        key = 3;
        Console.WriteLine($"Key {key} had value: {lookupIntString[key]}");

        Console.WriteLine("==================================");

        // Assign the method to the shout delegate.
        harry.Shout += Harry_Shout;
        harry.Shout += Harry_Shout_2;
        
        // Call the poke method that eventually raises the Shout event.
        harry.Poke();
        harry.Poke();
        harry.Poke();
        harry.Poke();

        Console.WriteLine("==================================");

        Person?[] people = 
        {
            null,
            new() {Name = "Simon"},
            new() {Name = "Jenny"},
            new() {Name = "Adam"},
            new() {Name = null},
            new() {Name = "Richard"}
        };

        OutputPeopleNames(people, "Initial list of people:");

        Array.Sort(people);
        
        OutputPeopleNames(people, "After sorting using Person's IComparable implementation");
    }
}

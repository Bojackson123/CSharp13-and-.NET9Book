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

        Array.Sort(people, new PersonComparer());

        OutputPeopleNames(people, "After sorting using PersonComparer's IComparer implementation");

        Console.WriteLine("==================================");

        Employee john = new()
        {
            Name = "John Jones",
            Born = new(1990, 7, 28, 0, 0, 0, TimeSpan.Zero)
        };

        john.WriteToConsole();

        john.EmployeeCode = "JJ001";
        john.HireDate = new(2014, 11, 23);
        Console.WriteLine($"{john.Name} was hired on {john.HireDate:yyyy-MM-dd}.");

        Console.WriteLine(john.ToString());

        Employee aliceInEmployee = new() {Name = "Alice", EmployeeCode = "AA123"};
        Person aliceInPerson = aliceInEmployee;
        aliceInEmployee.WriteToConsole();
        aliceInPerson.WriteToConsole();
        Console.WriteLine(aliceInEmployee.ToString());
        Console.WriteLine(aliceInPerson.ToString());

        if (aliceInPerson is Employee)
        {
            Console.WriteLine($"{nameof(aliceInPerson)} is an Employee");
            Employee explicitAlice = (Employee)aliceInPerson;

            // Safely do something with explicitAlice
        }

        if (aliceInEmployee is Employee explicitAliceInline)
        {
            Console.WriteLine($"{nameof(aliceInPerson)} is an Employee");

            // Safely do something with explicitAliceInline
        }

        Employee? aliceAsEmployee = aliceInPerson as Employee;

        if (aliceAsEmployee is not null)
        {
            Console.WriteLine($"{nameof(aliceInPerson)} as an Employee");

            // Safely do something with aliceAsEmployee.
        }

        
        Console.WriteLine("==================================");

        try
        {
            john.TimeTravel(new(1999, 12, 31));
            john.TimeTravel(new(1950, 12, 25)); 
        }
        catch (PersonException ex)
        {
            Console.WriteLine(ex.Message);
        }
        
        Console.WriteLine("==================================");

        string email1 = "pamela@test.com";
        string email2 = "ian&test.com";

        Console.WriteLine($"{email1} is a valid e-mail address: {StringExtensions.IsValidEmail(email1)}");
        
        Console.WriteLine($"{email2} is a valid e-mail address: {StringExtensions.IsValidEmail(email2)}");

        Console.WriteLine($"{email1} is a valid e-mail address: {email1.IsValidEmail()}");

        Console.WriteLine($"{email2} is a valid e-mail address: {email2.IsValidEmail()}");
        

        Console.WriteLine("==================================");

        C1 c1 = new() {Name = "Bob"};
        c1.Name = "Bill";

        C2 c2 = new(Name: "Bob");
        //c2.Name = "Bill"; // CS8852: Init-only property.

        S1 s1 = new() {Name = "Bob"};
        s1.Name = "Bill";

        S2 s2 = new(Name: "Bob");
        s2.Name = "Bill";

        S3 s3 = new(Name: "Bob");
        //s3.Name = "Bill";
        
    }
}

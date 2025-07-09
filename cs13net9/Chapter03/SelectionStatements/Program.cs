namespace SelectionStatements;


class Program
{
    static void Main(string[] args)
    {
        string password = "ninja";

        if (password.Length < 8)
        {
            Console.WriteLine("Your password is too short. Use at least 8 chars.");
        }
        else
        {
            Console.WriteLine("Your password is strong.");
            
        }

        // Pattern Matching i.e 'o is int i' = if object store in o is of type int; assign to i.
        // Add and remove the "" to change between string and int.
        object o = 3;
        int j = 4;

        if (o is int i)
        {
            Console.WriteLine($"{i} x {j} = {i * j}");
        }
        else
        {
            Console.WriteLine("o is not an int so it cannot multiply");
        }


        //Switch Statements
        //Inclusive Lower bound but exclusive upper bound.
        int number = Random.Shared.Next(minValue: 1, maxValue: 7);
        Console.WriteLine($"My random number is {number}");

        switch (number)
        {
        case 1:
            Console.WriteLine("One");
            break; // Jumps to end of switch statement
        case 2:
            Console.WriteLine("Two");
            goto case 1;
        case 3: // Multiple case section.
        case 4:
            Console.WriteLine("Three or Four");
            goto case 1;
        case 5:
            goto A_label;
        default:
            Console.WriteLine("Default");
            break;
        } // End of switch statement.
        Console.WriteLine("After end of switch");
        A_label:
        Console.WriteLine($"After A_label");


        var animals = new Animal?[]
        {
            new Cat {Name = "Karen", Born = new(2022, 8, 23), Legs = 4, IsDomestic = true },
            null,
            new Cat {Name = "Mufasa", Born = new(1994, 6, 12) },
            new Spider {Name = "Sid Vicious", Born = DateTime.Today, IsVenomous = true},
            new Spider {Name = "Captain Furry", Born = DateTime.Today},
        };

        foreach (Animal? animal in animals)
        {
            string message;

            switch (animal)
            {
                case Cat fourLeggedCat when fourLeggedCat.Legs == 4:
                    message = $"The cat name {fourLeggedCat.Name} has four legs.";
                    break;
                case Cat wildCat when wildCat.IsDomestic == false:
                    message = $"The non-domestic cat is named {wildCat.Name}.";
                    break;
                case Cat cat:
                    message = $"The cat is name {cat.Name}";
                    break;
                default:
                    message = $"{animal.Name} is a {animal.GetType().Name}.";
                    break;
                case Spider spider when spider.IsVenomous:
                    message = $"The {spider.Name} spider is venomous. Run!";
                    break;
                case null:
                    message = "The animal is null.";
                    break;
                
            }
            Console.WriteLine($"switch statement: {message}");
        }

        
        
    }
}

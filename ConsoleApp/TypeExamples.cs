internal static class TypeExamples
{
    public static void Run()
    {
        string? maybeName = null;
        if (maybeName == null)
        {
            Console.WriteLine("maybeName is null");
        }

        if (maybeName is null)
        {
            Console.WriteLine("is also checks for null");
        }

        maybeName = "Alice";
        if (maybeName is not null)
        {
            Console.WriteLine($"Name: {maybeName}");
        }

        // is checks a type and creates a typed variable at the same time.
        object? unknownValue = 42;
        if (unknownValue is int number)
        {
            Console.WriteLine($"Number: {number}");
        }

        // as tries a reference-type conversion and returns null if it fails.
        object? possibleText = 123;
        string? convertedText = possibleText as string;
        if (convertedText is null)
        {
            Console.WriteLine("The value was not a string.");
        }

        if (unknownValue is int)
        {
            Console.WriteLine("unknownValue contains an int.");
        }

        // GetType() reports the runtime type of a non-null value.
        if (unknownValue is not null)
        {
            Console.WriteLine($"Runtime type: {unknownValue.GetType().Name}");
        }

        // typeof gets a Type object from a type name at compile time.
        Console.WriteLine($"Type object: {typeof(int).Name}");

        Player firstPlayer = new("Alice", 95);
        Player secondPlayer = new("Alice", 95);
        Player differentPlayer = new("Alice", 90);
        Console.WriteLine(firstPlayer == secondPlayer);
        Console.WriteLine(firstPlayer.Equals(secondPlayer));
        Console.WriteLine(firstPlayer == differentPlayer);

        // Positional record properties cannot be changed directly.
        Player originalPlayer = new("Alice", 95);
        // with creates a new record and leaves the original unchanged.
        Player updatedPlayer = originalPlayer with { Score = 100 };
        Console.WriteLine($"{originalPlayer.Name}: {originalPlayer.Score}");
        Console.WriteLine($"{updatedPlayer.Name}: {updatedPlayer.Score}");

        // A record can be made mutable by declaring settable properties.
        MutablePlayer mutablePlayer = new() { Name = "Bob" };
        mutablePlayer.Name = "Robert";
        Console.WriteLine(mutablePlayer.Name);
    }
}

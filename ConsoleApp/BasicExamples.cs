internal static class BasicExamples
{
    public static void Run()
    {
        // Top-level statements let a small console program begin without declaring
        // a class or a Main method explicitly, unlike the traditional Java entry point.
        Console.WriteLine("hello, world!");

        Console.Write("what is your favorite color? ");
        string? favoriteColor = Console.ReadLine();
        Console.WriteLine("oh, i love " + favoriteColor + " too!");

        // Console.ReadLine() returns text or null; it does not convert input to int.
        Console.Write("How old are you? ");
        string? ageInput = Console.ReadLine();

        // The ? belongs after the type: the variable may hold a string or null.
        // TryParse converts valid text and returns false instead of throwing.
        switch (ageInput)
        {
            case null:
                Console.WriteLine("No input was received.");
                break;
            case string input when string.IsNullOrWhiteSpace(input):
                Console.WriteLine("You pressed Enter without typing an age.");
                break;
            case string input when int.TryParse(input, out int age):
                Console.WriteLine($"Next year you will be {age + 1}.");
                break;
            default:
                Console.WriteLine("Please enter a whole number.");
                break;
        }

        string first = "Hello";
        string last = "world";
        // The + operator joins strings. String interpolation is another common option.
        string message = first + ", " + last + "!";
        Console.WriteLine(message);

        // String interpolation inserts the value between braces.
        string? name = "Alex";
        Console.WriteLine($"Hello, {name}!");

        // ReadLine() returns string?, so check for null before using the value.
        name = Console.ReadLine();
        if (name is not null)
        {
            Console.WriteLine($"Hello, {name}! Nice to meet you.");

            // C# uses the Length property; Java uses the length() method.
            Console.WriteLine(name.Length);

            Console.Write("What's your name? ");
            name = Console.ReadLine();
            if (name is not null)
            {
                // Strings are immutable; ToUpper() and ToLower() return new strings.
                string greeting = $"Welcome, {name.ToUpper()}!";
                Console.WriteLine(greeting);
            }
        }
    }
}

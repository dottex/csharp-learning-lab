// Top-level statements let a small console program begin without declaring a class
// or a Main method explicitly, unlike the traditional Java entry point.
Console.WriteLine("hello, world!");

Console.Write("what is your favorite color? ");
string? favoritecolor = Console.ReadLine();
Console.WriteLine("oh, i love " + favoritecolor + " too!");

// Console.ReadLine() always returns text (or null at end-of-input); it does not
// convert the user's input to an int automatically, as this value is still a string.
Console.Write("How old are you? ");
string? ageInput = Console.ReadLine();
// The ? belongs after the type: the variable may hold a string or null.
// TryParse converts valid text and returns false instead of throwing on bad input.
if (ageInput is null)
{
    Console.WriteLine("No input was received.");
}
else if (string.IsNullOrWhiteSpace(ageInput))
{
    Console.WriteLine("You pressed Enter without typing an age.");
}
else if (int.TryParse(ageInput, out int age))
{
    Console.WriteLine($"Next year you will be {age + 1}.");
}
else
{
    Console.WriteLine("Please enter a whole number.");
}

string first = "Hello";
string last = "world";
// The + operator joins strings. String interpolation ($"...") is another
// common C# option when values need to be embedded in a message.
string message = first + ", " + last + "!";
Console.WriteLine(message);

// String interpolation inserts the value of name into the text between braces.
string? name = "Alex";
Console.WriteLine($"Hello, {name}!");

// ReadLine() returns string?, so assigning it to string assumes the input
// is not null. Nullable reference types warn us about that assumption.
name = Console.ReadLine();
if (name is not null)
{
    Console.WriteLine($"Hello, {name}! Nice to meet you.");

    // C# uses the Length property for strings; Java uses the length() method.
    Console.WriteLine(name.Length);

    Console.Write("What's your name? ");
    name = Console.ReadLine();
    if (name is not null)
    {
        // ToUpper() returns a new uppercase string because strings are immutable.
        // The related ToLower() method returns a lowercase copy.
        string greeting = $"Welcome, {name.ToUpper()}!";
        Console.WriteLine(greeting);
    }
}

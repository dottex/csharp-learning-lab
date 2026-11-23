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

name = "Alice";
// int stores whole numbers. double is a common choice for measurements such
// as temperature, similar to Java's double type.
int ageInt = 25;
double temperature = 98.6;
// The m suffix also works with a whole-number decimal value.
decimal wholePrice = 20m;
// A decimal literal with digits after the point needs the m suffix.
decimal exactPrice = 19.99m;
// bool stores one of two values: true or false.
bool isRaining = true;
Console.WriteLine($"Age: {ageInt}, temperature: {temperature}, prices: {wholePrice}/{exactPrice}, raining: {isRaining}");


int messageCount = 5;
Console.WriteLine(messageCount + 1);   // Output: 6

var nameVar = "Alice";           // C# sees a string, so name is string
var ageVar = 25;                 // C# sees a whole number, so age is int
// A fractional number is double by default. Add m when var should infer decimal.
var price = 19.99;              // price is double
var decimalPrice = 19.99m;      // decimalPrice is decimal
Console.WriteLine($"var values: {nameVar}, {ageVar}, {price}, {decimalPrice}");

// Top-level statements let a small console program begin without declaring a class
// or a Main method explicitly, unlike the traditional Java entry point.
Console.WriteLine("hello, world!");

Console.Write("what is your favorite color? ");
string? favoritecolor = Console.ReadLine();
Console.WriteLine("oh, i love " + favoritecolor + " too!");

// Console.ReadLine() always returns text (or null at end-of-input); it does not
// convert the user's input to an int automatically, as this value is still a string.
string? age = Console.ReadLine();
// Adding 1 here would concatenate text, not perform numeric addition.
Console.WriteLine(age + 1);

string first = "Hello";
string last = "world";
// The + operator joins strings. String interpolation ($"...") is another
// common C# option when values need to be embedded in a message.
string message = first + ", " + last + "!";
Console.WriteLine(message);

string name = "Alex";
Console.WriteLine($"Hello, {name}!");

name = Console.ReadLine();
Console.WriteLine($"Hello, {name}! Nice to meet you.");

Console.WriteLine(name.Length);

Console.Write("What's your name? ");
name = Console.ReadLine();
string greeting = $"Welcome, {name.ToUpper()}!";
Console.WriteLine(greeting);

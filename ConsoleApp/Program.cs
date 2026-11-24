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
    case string input when int.TryParse(input, out int ageAuto):
        Console.WriteLine($"Next year you will be {ageAuto + 1}.");
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
// Without m or another decimal context, a fractional number is double by default.
// var can infer decimal when the value already has decimal type.
var price = 19.99;              // price is double
var decimalPrice = 19.99m;      // decimalPrice is decimal
decimal sourcePrice = 10.00m;
var copiedPrice = sourcePrice;  // copiedPrice is decimal
Console.WriteLine($"var values: {nameVar}, {ageVar}, {price}, {decimalPrice}, {copiedPrice}");


int score = 95;
decimal priceDecimal = 19.99m;
double average = 87.5;


int a = 7;
int b = 2;
Console.WriteLine(a / b);        // Output: 3 (integer division truncates)

decimal c = 7m;
decimal d = 2m;
Console.WriteLine(c / d);        // Output: 3.5 (keeps the decimal)


Console.WriteLine(10 % 2);   // Output: 0 (10 is even)
Console.WriteLine(11 % 2);   // Output: 1 (11 is odd)


int standard = 2 + 3 * 4;      // Multiplication first: 14
int forced = (2 + 3) * 4;      // Parentheses first: 20
Console.WriteLine($"standard: {standard}, forced: {forced}");

score = 50;
score = score + 10;    // Standard way: score is 60
score += 10;           // Shorthand: score is 70


int count = 5;
count++;                       // Same as count = count + 1
Console.WriteLine(count);      // Output: 6

count--;                       // Same as count = count - 1
Console.WriteLine(count);      // Output: 5

a = 5;
Console.WriteLine(a++);   // Output: 5 (uses old value, then increments)
Console.WriteLine(a);     // Output: 6 (a was incremented)

b = 5;
Console.WriteLine(++b);   // Output: 6 (increments first, then uses new value)
Console.WriteLine(b);     // Output: 6

int result = 7 / 2;
Console.WriteLine(result);     // Output: 3 (not 3.5)

decimal result2 = 7m / 2m;
Console.WriteLine(result2);     // Output: 3.5


Console.Write("Enter your age: ");
ageInput = Console.ReadLine();
int age = Convert.ToInt32(ageInput);
int nextYear = age + 1;
Console.WriteLine($"Next year you'll be {nextYear}");


age = int.Parse("25");
decimal priceOfMoney = decimal.Parse("19.99");
average = double.Parse("87.5");

priceDecimal = 19.99m;
wholePrice = (int)priceDecimal;         // Casts to int: 19 (decimal dropped)
Console.WriteLine(wholePrice);       // Output: 19

int firstInt = 7;
int secondInt = 2;
decimal resultInDecimal = (decimal)firstInt / (decimal)secondInt;
// :C formats the decimal as currency using the current culture.
Console.WriteLine($"{resultInDecimal:C}");           // Output: a currency value such as $3.50

// Arrays have a fixed size and use zero-based indexes, like Java arrays.
int[] scores = { 80, 95, 72 };
for (int index = 0; index < scores.Length; index++)
{
    Console.WriteLine($"score {index}: {scores[index]}");
}

// foreach visits each item without managing an index.
foreach (int scoreItem in scores)
{
    Console.WriteLine($"score: {scoreItem}");
}

int countdown = 3;
while (countdown > 0)
{
    Console.WriteLine(countdown);
    countdown--;
}

// Dictionary<TKey, TValue> stores key-value pairs, like Java Map.
Dictionary<string, int> scoresByName = new()
{
    ["Alice"] = 95,
    ["Bob"] = 80
};
Console.WriteLine($"Alice's score: {scoresByName["Alice"]}");

// HashSet<T> stores unique values, like Java Set.
HashSet<string> colors = new() { "red", "blue", "red" };
colors.Add("green");
Console.WriteLine($"Unique colors: {colors.Count}");

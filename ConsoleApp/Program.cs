Console.WriteLine("hello, world!");

Console.Write("what is your favorite color? ");
string? favoritecolor = Console.ReadLine();
Console.WriteLine("oh, i love " + favoritecolor + " too!");

string? age = Console.ReadLine();//Does not convert to int automatically
Console.WriteLine(age + 1); //Prints ##1 !!

string first = "Hello";
string last = "world";
string message = first + ", " + last + "!";
Console.WriteLine(message);
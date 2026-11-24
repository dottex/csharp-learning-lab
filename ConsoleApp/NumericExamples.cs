internal static class NumericExamples
{
    public static void Run()
    {
        // int stores whole numbers. double is common for measurements, like Java double.
        int ageInt = 25;
        double temperature = 98.6;
        // The m suffix marks a decimal literal; it also works with whole numbers.
        decimal wholePrice = 20m;
        decimal exactPrice = 19.99m;
        bool isRaining = true;
        Console.WriteLine($"Age: {ageInt}, temperature: {temperature}, prices: {wholePrice}/{exactPrice}, raining: {isRaining}");

        int messageCount = 5;
        Console.WriteLine(messageCount + 1);

        var nameVar = "Alice"; // string
        var ageVar = 25; // int
        // Without m, a fractional number is double by default.
        // var can infer decimal from an existing decimal value.
        var price = 19.99; // double
        var decimalPrice = 19.99m; // decimal
        decimal sourcePrice = 10.00m;
        var copiedPrice = sourcePrice; // decimal
        Console.WriteLine($"var values: {nameVar}, {ageVar}, {price}, {decimalPrice}, {copiedPrice}");

        int score = 95;
        decimal priceDecimal = 19.99m;
        double average = 87.5;

        int a = 7;
        int b = 2;
        Console.WriteLine(a / b); // 3: integer division truncates

        decimal c = 7m;
        decimal d = 2m;
        Console.WriteLine(c / d); // 3.5: decimal division keeps the fraction

        Console.WriteLine(10 % 2); // 0: 10 is even
        Console.WriteLine(11 % 2); // 1: 11 is odd

        int standard = 2 + 3 * 4; // Multiplication first: 14
        int forced = (2 + 3) * 4; // Parentheses first: 20
        Console.WriteLine($"standard: {standard}, forced: {forced}");

        score = 50;
        score = score + 10;
        score += 10;

        int count = 5;
        count++;
        Console.WriteLine(count);
        count--;
        Console.WriteLine(count);

        a = 5;
        Console.WriteLine(a++); // Uses old value, then increments
        Console.WriteLine(a);
        b = 5;
        Console.WriteLine(++b); // Increments first, then uses new value
        Console.WriteLine(b);

        int result = 7 / 2;
        Console.WriteLine(result);
        decimal result2 = 7m / 2m;
        Console.WriteLine(result2);

        Console.Write("Enter your age: ");
        string? ageInput = Console.ReadLine();
        int age = Convert.ToInt32(ageInput);
        int nextYear = age + 1;
        Console.WriteLine($"Next year you'll be {nextYear}");

        age = int.Parse("25");
        decimal priceOfMoney = decimal.Parse("19.99");
        average = double.Parse("87.5");

        priceDecimal = 19.99m;
        wholePrice = (int)priceDecimal; // Casts to int: 19
        Console.WriteLine(wholePrice);

        int firstInt = 7;
        int secondInt = 2;
        decimal resultInDecimal = (decimal)firstInt / (decimal)secondInt;
        // :C formats the decimal as currency using the current culture.
        Console.WriteLine($"{resultInDecimal:C}");
    }
}

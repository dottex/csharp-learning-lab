internal static class CollectionExamples
{
    public static void Run()
    {
        // Arrays have a fixed size and use zero-based indexes, like Java arrays.
        int[] scores = { 80, 95, 72 };
        for (int index = 0; index < scores.Length; index++)
        {
            Console.WriteLine($"score {index}: {scores[index]}");
        }

        // foreach visits each item without managing an index.
        foreach (int score in scores)
        {
            Console.WriteLine($"score: {score}");
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

        foreach (string playerName in scoresByName.Keys)
        {
            Console.WriteLine($"key: {playerName}");
        }

        foreach (int playerScore in scoresByName.Values)
        {
            Console.WriteLine($"value: {playerScore}");
        }

        foreach (KeyValuePair<string, int> entry in scoresByName)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }

        scoresByName["Carol"] = 88;
        // TryAdd returns false instead of replacing an existing value.
        bool addedScore = scoresByName.TryAdd("Alice", 100);
        Console.WriteLine($"Alice added again: {addedScore}");

        // HashSet<T> stores unique values, like Java Set.
        HashSet<string> colors = new() { "red", "blue", "red" };
        colors.Add("green");
        Console.WriteLine($"Unique colors: {colors.Count}");
        foreach (string color in colors)
        {
            Console.WriteLine($"color: {color}");
        }

        // A record creates objects with value-based equality.
        HashSet<Player> players = new()
        {
            new Player("Alice", 95),
            new Player("Bob", 80),
            new Player("Alice", 95)
        };
        players.Add(new Player("Carol", 88));

        foreach (Player player in players)
        {
            Console.WriteLine($"{player.Name}: {player.Score}");
        }

        // A dictionary can store records as its values.
        Dictionary<string, Player> playersByName = new()
        {
            ["Alice"] = new Player("Alice", 95)
        };

        // Add or replace a value by assigning it to a key.
        playersByName["Bob"] = new Player("Bob", 80);

        // TryAdd adds only when the key does not already exist.
        bool addedPlayer = playersByName.TryAdd("Carol", new Player("Carol", 88));
        Console.WriteLine($"Carol added: {addedPlayer}");

        foreach (KeyValuePair<string, Player> entry in playersByName)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value.Score}");
        }
    }
}

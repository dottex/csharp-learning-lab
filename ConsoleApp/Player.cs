// This positional record declares Name and Score properties.
// It also creates value-based equality, unlike a basic class by default.
internal record Player(string Name, int Score);

internal record MutablePlayer
{
    public string Name { get; set; } = "";
}

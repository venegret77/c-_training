namespace CsharpLecture2Practice.Examples;

/// <summary>
/// Пример к блоку 7: pattern matching в switch expression.
/// Смотри перед Describe и Grade.
/// </summary>
public static class PatternMatchingExample
{
    public static void Demo()
    {
        object?[] values = [42, "hello", "", true, null, 3.14];

        foreach (var value in values)
        {
            Console.WriteLine($"{Describe(value)} | Grade(85) = {Grade(85)}");
        }
    }

    public static string Describe(object? value) => value switch
    {
        null => "null",
        int n => $"number:{n}",
        string s when string.IsNullOrEmpty(s) => "text:empty",
        string s => $"text:{s}",
        bool b => $"flag:{b}",
        _ => "unknown"
    };

    public static string Grade(int score)
    {
        // Relational pattern — можно и через if-else
        return score switch
        {
            < 0 or > 100 => "invalid",
            >= 90 => "A",
            >= 75 => "B",
            >= 60 => "C",
            >= 40 => "D",
            _ => "F"
        };
    }
}

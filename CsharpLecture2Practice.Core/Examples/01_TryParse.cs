namespace CsharpLecture2Practice.Examples;

/// <summary>
/// Пример к блоку 1: int.TryParse и проверка диапазона.
/// Смотри перед решением TryParseUserChoice в Lecture2Exercises.cs.
/// </summary>
public static class TryParseExample
{
    public static void Demo()
    {
        Console.WriteLine("=== TryParse ===");

        var inputs = new[] { "1", "5", "abc", null };

        foreach (var input in inputs)
        {
            if (TryParseMenuChoice(input, out var choice))
            {
                Console.WriteLine($"OK: выбран пункт {choice}");
            }
            else
            {
                Console.WriteLine($"Ошибка: '{input ?? "null"}' — неверный ввод");
            }
        }
    }

    /// <summary>
    /// Упрощённый аналог TryParseUserChoice из задач.
    /// </summary>
    public static bool TryParseMenuChoice(string? input, out int choice)
    {
        // TryParse возвращает false, если строка не число
        if (!int.TryParse(input, out choice))
        {
            return false;
        }

        // Проверяем диапазон 0..3
        return choice is >= 0 and <= 3;
    }
}

namespace CsharpLecture2Practice.Examples;

/// <summary>
/// Пример к блоку 4: цикл for.
/// Смотри перед CountMultiples и BuildSequence.
/// </summary>
public static class ForExample
{
    public static void Demo()
    {
        var numbers = new[] { 2, 4, 7, 8, 10 };

        Console.WriteLine($"Кратных 2: {CountMultiples(numbers, 2)}");
        Console.WriteLine($"Sequence(5) = [{string.Join(", ", BuildSequence(5))}]");
    }

    public static int CountMultiples(int[] numbers, int divisor)
    {
        var count = 0;

        // for — когда нужен индекс или точное число итераций
        for (var i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % divisor == 0)
            {
                count++;
            }
        }

        return count;
    }

    public static int[] BuildSequence(int count)
    {
        var result = new int[count];

        for (var i = 0; i < count; i++)
        {
            result[i] = i; // 0, 1, 2, ...
        }

        return result;
    }
}

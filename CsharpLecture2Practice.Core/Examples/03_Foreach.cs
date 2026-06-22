namespace CsharpLecture2Practice.Examples;

/// <summary>
/// Пример к блоку 3: цикл foreach.
/// Смотри перед SumNumbers и GetEvenNumbers.
/// </summary>
public static class ForeachExample
{
    public static void Demo()
    {
        var numbers = new[] { 1, 2, 3, 4, 5, 6 };

        Console.WriteLine($"Sum = {SumNumbers(numbers)}");
        Console.WriteLine($"Evens = [{string.Join(", ", GetEvenNumbers(numbers))}]");
    }

    public static int SumNumbers(int[] numbers)
    {
        var sum = 0;

        // foreach — перебор каждого элемента
        foreach (var n in numbers)
        {
            sum += n;
        }

        return sum;
    }

    public static int[] GetEvenNumbers(int[] numbers)
    {
        var evens = new List<int>();

        foreach (var n in numbers)
        {
            if (n % 2 == 0)
            {
                evens.Add(n);
            }
        }

        return evens.ToArray();
    }
}

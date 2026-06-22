namespace CsharpLecture2Practice.Examples;

/// <summary>
/// Пример к блоку 5: цикл while.
/// Смотри перед Factorial и CountHalvingSteps.
/// </summary>
public static class WhileExample
{
    public static void Demo()
    {
        Console.WriteLine($"5! = {Factorial(5)}");
        Console.WriteLine($"Halving(20, 5) = {CountHalvingSteps(20, 5)} шагов");
    }

    public static long Factorial(int n)
    {
        long result = 1;

        // while — пока условие истинно
        while (n > 1)
        {
            result *= n;
            n--;
        }

        return result;
    }

    public static int CountHalvingSteps(int number, int threshold)
    {
        var steps = 0;

        while (number > threshold)
        {
            number /= 2;
            steps++;
        }

        return steps;
    }
}

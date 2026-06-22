// ═══════════════════════════════════════════════════════════════════════
// ОТВЕТЫ — смотри только если застрял!
// Скопируй нужный метод в Lecture2Exercises.cs или сверься с реализацией.
// ═══════════════════════════════════════════════════════════════════════

namespace CsharpLecture2Practice;

public static class Lecture2ExercisesAnswers
{
    public static bool TryParseUserChoice(string? input, out int choice)
    {
        if (!int.TryParse(input, out choice))
        {
            return false;
        }

        return choice is >= 0 and <= 3;
    }

    public static string? ChoiceToString(int choice) => choice switch
    {
        1 => "Rock",
        2 => "Paper",
        3 => "Scissors",
        _ => null
    };

    public static string GetRoundResultText(int userChoice, int computerChoice)
    {
        if (userChoice == computerChoice)
        {
            return "Draw";
        }

        var userWins =
            (userChoice == 1 && computerChoice == 3) ||
            (userChoice == 2 && computerChoice == 1) ||
            (userChoice == 3 && computerChoice == 2);

        return userWins ? "You win" : "You lose";
    }

    public static int SumNumbers(int[] numbers)
    {
        var sum = 0;
        foreach (var n in numbers)
        {
            sum += n;
        }

        return sum;
    }

    public static int[] GetEvenNumbers(int[] numbers)
    {
        var result = new List<int>();
        foreach (var n in numbers)
        {
            if (n % 2 == 0)
            {
                result.Add(n);
            }
        }

        return result.ToArray();
    }

    public static int CountMultiples(int[] numbers, int divisor)
    {
        var count = 0;
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
            result[i] = i;
        }

        return result;
    }

    public static long Factorial(int n)
    {
        long result = 1;
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

    public static void DoublePointX(ref Point point)
    {
        point.X *= 2;
    }

    public static void AddBalance(Player player, int amount)
    {
        player.Balance += amount;
    }

    public static int SafeLength(string? text)
    {
        if (text is null)
        {
            return 0;
        }

        return text.Length;
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
        if (score is < 0 or > 100)
        {
            return "invalid";
        }

        if (score >= 90)
        {
            return "A";
        }

        if (score >= 75)
        {
            return "B";
        }

        if (score >= 60)
        {
            return "C";
        }

        if (score >= 40)
        {
            return "D";
        }

        return "F";
    }
}

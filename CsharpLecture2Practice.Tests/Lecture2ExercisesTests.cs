namespace CsharpLecture2Practice.Tests;

/// <summary>
/// ╔══════════════════════════════════════════════════════════════════════╗
/// ║  ТЕСТЫ — автопроверка задач из Lecture2Exercises.cs                 ║
/// ║                                                                      ║
/// ║  Этот файл НЕ редактируем. Он показывает, что именно проверяется.   ║
/// ║                                                                      ║
/// ║  Как запустить в Rider:                                              ║
/// ║    • Зелёный ▶ слева от [Fact] / [Theory] — один тест                ║
/// ║    • ПКМ по классу → Run Unit Tests — все тесты                      ║
/// ║    • Alt+8 → окно Unit Tests → Run All                               ║
/// ║    • Терминал: dotnet test                                           ║
/// ║                                                                      ║
/// ║  Красный тест? Читай сообщение Assert — там Expected vs Actual.      ║
/// ║  Подробности по каждой задаче — в ИНСТРУКЦИЯ.md                      ║
/// ╚══════════════════════════════════════════════════════════════════════╝
/// </summary>
public class Lecture2ExercisesTests
{
    // ── Блок 1: TryParseUserChoice ───────────────────────────────────────
    // Задача 1 | Пример: Examples/01_TryParse.cs

    [Theory]
    [InlineData("0", 0, true)]
    [InlineData("1", 1, true)]
    [InlineData("3", 3, true)]
    [InlineData("4", 0, false)]
    [InlineData("-1", 0, false)]
    [InlineData("abc", 0, false)]
    [InlineData("", 0, false)]
    [InlineData(null, 0, false)]
    [InlineData(" 2 ", 0, false)]
    public void TryParseUserChoice_ValidatesInput(string? input, int expectedChoice, bool expectedSuccess)
    {
        var success = Lecture2Exercises.TryParseUserChoice(input, out var choice);

        Assert.Equal(expectedSuccess, success);
        if (expectedSuccess)
        {
            Assert.Equal(expectedChoice, choice);
        }
    }

    // ── Блок 2: ChoiceToString, GetRoundResultText ───────────────────────
    // Задачи 2a, 2b | Пример: Examples/02_SwitchAndIfElse.cs

    [Theory]
    [InlineData(1, "Rock")]
    [InlineData(2, "Paper")]
    [InlineData(3, "Scissors")]
    [InlineData(0, null)]
    [InlineData(99, null)]
    public void ChoiceToString_ReturnsCorrectName(int choice, string? expected)
    {
        Assert.Equal(expected, Lecture2Exercises.ChoiceToString(choice));
    }

    [Theory]
    [InlineData(1, 1, "Draw")]
    [InlineData(1, 3, "You win")]
    [InlineData(3, 1, "You lose")]
    [InlineData(2, 1, "You win")]
    [InlineData(1, 2, "You lose")]
    [InlineData(3, 2, "You win")]
    [InlineData(2, 3, "You win")]
    public void GetRoundResultText_RockPaperScissors(int user, int computer, string expected)
    {
        Assert.Equal(expected, Lecture2Exercises.GetRoundResultText(user, computer));
    }

    // ── Блок 3: foreach — SumNumbers, GetEvenNumbers ─────────────────────
    // Задачи 3a, 3b | Пример: Examples/03_Foreach.cs

    [Fact]
    public void SumNumbers_EmptyArray_ReturnsZero()
    {
        Assert.Equal(0, Lecture2Exercises.SumNumbers([]));
    }

    [Fact]
    public void SumNumbers_SumsAllElements()
    {
        Assert.Equal(10, Lecture2Exercises.SumNumbers([1, 2, 3, 4]));
    }

    [Fact]
    public void GetEvenNumbers_FiltersCorrectly()
    {
        Assert.Equal([2, 4, 6], Lecture2Exercises.GetEvenNumbers([1, 2, 3, 4, 5, 6]));
    }

    [Fact]
    public void GetEvenNumbers_AllOdd_ReturnsEmpty()
    {
        Assert.Empty(Lecture2Exercises.GetEvenNumbers([1, 3, 5]));
    }

    // ── Блок 4: for — CountMultiples, BuildSequence ────────────────────────
    // Задачи 4a, 4b | Пример: Examples/04_For.cs

    [Theory]
    [InlineData(new[] { 2, 4, 7, 8 }, 2, 3)]
    [InlineData(new int[0], 5, 0)]
    [InlineData(new[] { 10, 20 }, 3, 0)]
    public void CountMultiples_Works(int[] numbers, int divisor, int expected)
    {
        Assert.Equal(expected, Lecture2Exercises.CountMultiples(numbers, divisor));
    }

    [Theory]
    [InlineData(0, new int[0])]
    [InlineData(1, new[] { 0 })]
    [InlineData(5, new[] { 0, 1, 2, 3, 4 })]
    public void BuildSequence_Works(int count, int[] expected)
    {
        Assert.Equal(expected, Lecture2Exercises.BuildSequence(count));
    }

    // ── Блок 5: while — Factorial, CountHalvingSteps ──────────────────────
    // Задачи 5a, 5b | Пример: Examples/05_While.cs

    [Theory]
    [InlineData(0, 1)]
    [InlineData(1, 1)]
    [InlineData(5, 120)]
    [InlineData(10, 3628800)]
    public void Factorial_Works(int n, long expected)
    {
        Assert.Equal(expected, Lecture2Exercises.Factorial(n));
    }

    [Theory]
    [InlineData(20, 5, 2)]
    [InlineData(8, 10, 0)]
    [InlineData(16, 1, 4)]
    public void CountHalvingSteps_Works(int number, int threshold, int expected)
    {
        Assert.Equal(expected, Lecture2Exercises.CountHalvingSteps(number, threshold));
    }

    // ── Блок 6: value vs reference ─────────────────────────────────────────
    // Задачи 6a, 6b, 6c | Пример: Examples/06_ValueVsReference.cs

    [Fact]
    public void DoublePointX_ModifiesStruct()
    {
        var point = new Point(3, 7);
        Lecture2Exercises.DoublePointX(ref point);
        Assert.Equal(6, point.X);
        Assert.Equal(7, point.Y);
    }

    [Fact]
    public void AddBalance_ModifiesPlayerObject()
    {
        var player = new Player(100);
        Lecture2Exercises.AddBalance(player, 50);
        Assert.Equal(150, player.Balance);
    }

    [Fact]
    public void SafeLength_HandlesNullAndText()
    {
        Assert.Equal(0, Lecture2Exercises.SafeLength(null));
        Assert.Equal(5, Lecture2Exercises.SafeLength("hello"));
        Assert.Equal(0, Lecture2Exercises.SafeLength(""));
    }

    // ── Блок 7: pattern matching — Describe, Grade ───────────────────────
    // Задачи 7a, 7b | Пример: Examples/07_PatternMatching.cs

    [Theory]
    [InlineData(42, "number:42")]
    [InlineData("hi", "text:hi")]
    [InlineData("", "text:empty")]
    [InlineData(true, "flag:True")]
    [InlineData(false, "flag:False")]
    public void Describe_Patterns(object? value, string expected)
    {
        Assert.Equal(expected, Lecture2Exercises.Describe(value));
    }

    [Fact]
    public void Describe_Null_ReturnsNullString()
    {
        Assert.Equal("null", Lecture2Exercises.Describe(null));
    }

    [Fact]
    public void Describe_UnknownType_ReturnsUnknown()
    {
        Assert.Equal("unknown", Lecture2Exercises.Describe(3.14));
    }

    [Theory]
    [InlineData(95, "A")]
    [InlineData(90, "A")]
    [InlineData(75, "B")]
    [InlineData(60, "C")]
    [InlineData(40, "D")]
    [InlineData(39, "F")]
    [InlineData(0, "F")]
    [InlineData(-1, "invalid")]
    [InlineData(101, "invalid")]
    public void Grade_Works(int score, string expected)
    {
        Assert.Equal(expected, Lecture2Exercises.Grade(score));
    }
}

namespace CsharpLecture2Practice;

/// <summary>
/// ╔══════════════════════════════════════════════════════════════════════╗
/// ║  ПРАКТИКА — ЛЕКЦИЯ 2                                                ║
/// ║                                                                      ║
/// ║  Где писать:  этот файл, места с // TODO: реализуй                  ║
/// ║  Как проверять: Tests/Lecture2ExercisesTests.cs → зелёный ▶ в Rider  ║
/// ║  Подсказки:   Core/Examples/01..08 — примеры по каждой теме         ║
/// ║  Инструкция:  ИНСТРУКЦИЯ.md в корне solution (открой в Rider)        ║
/// ║  Ответы:      Lecture2Exercises.Answers.cs — только если застрял     ║
/// ║                                                                      ║
/// ║  Rider: Alt+8 → Unit Tests | Ctrl+F9 → Build | Ctrl+Alt+L → формат  ║
/// ╚══════════════════════════════════════════════════════════════════════╝
/// </summary>
public static class Lecture2Exercises
{
    // ═══════════════════════════════════════════════════════════════════════
    // БЛОК 1. Парсинг и валидация
    // ───────────────────────────────────────────────────────────────────────
    // Пример:  Examples/01_TryParse.cs
    // Тест:    TryParseUserChoice_ValidatesInput
    // Тема:    int.TryParse, out-параметр, проверка диапазона
    // С лекции: Console.ReadLine() + проверка ввода в Rock Paper Scissors
    // ═══════════════════════════════════════════════════════════════════════

    /// <summary>
    /// ЗАДАЧА 1. Разобрать ввод пользователя.
    ///
    /// Где писать: тело метода ниже (замени TODO).
    ///
    /// Логика:
    ///   1) int.TryParse(input, out choice) — если false, вернуть false
    ///   2) choice должен быть от 0 до 3 включительно
    ///
    /// Таблица:
    ///   "1"   → true,  choice = 1
    ///   "0"   → true,  choice = 0  (выход из игры)
    ///   "5"   → false
    ///   "abc" → false
    ///   null  → false
    /// </summary>
    public static bool TryParseUserChoice(string? input, out int choice)
    {
        // TODO: реализуй (смотри Examples/01_TryParse.cs)
        choice = 0;
        return false;
    }

    // ═══════════════════════════════════════════════════════════════════════
    // БЛОК 2. Switch / switch expression / if-else
    // ───────────────────────────────────────────────────────────────────────
    // Пример:  Examples/02_SwitchAndIfElse.cs, Examples/08_RockPaperScissors_Lecture.cs
    // Тесты:   ChoiceToString_ReturnsCorrectName
    //          GetRoundResultText_RockPaperScissors
    // ═══════════════════════════════════════════════════════════════════════

    /// <summary>
    /// ЗАДАЧА 2a. Название хода по номеру.
    ///
    /// Где писать: return-выражение ниже.
    ///
    ///   1 → "Rock"    2 → "Paper"    3 → "Scissors"    иначе → null
    ///
    /// Используй switch expression: choice switch { 1 => "Rock", ... }
    /// </summary>
    public static string? ChoiceToString(int choice)
    {
        // TODO: реализуй (смотри Examples/02_SwitchAndIfElse.cs)
        return null;
    }

    /// <summary>
    /// ЗАДАЧА 2b. Результат раунда Rock Paper Scissors.
    ///
    /// Где писать: тело метода ниже.
    ///
    ///   Одинаковые числа     → "Draw"
    ///   Пользователь победил → "You win"
    ///   Иначе                → "You lose"
    ///
    /// Кто кого бьёт:
    ///   Rock(1) > Scissors(3)    Paper(2) > Rock(1)    Scissors(3) > Paper(2)
    /// </summary>
    public static string GetRoundResultText(int userChoice, int computerChoice)
    {
        // TODO: реализуй через if-else (смотри Examples/02_SwitchAndIfElse.cs)
        return string.Empty;
    }

    // ═══════════════════════════════════════════════════════════════════════
    // БЛОК 3. Цикл foreach
    // ───────────────────────────────────────────────────────────────────────
    // Пример:  Examples/03_Foreach.cs
    // Тесты:   SumNumbers_*, GetEvenNumbers_*
    // ═══════════════════════════════════════════════════════════════════════

    /// <summary>
    /// ЗАДАЧА 3a. Сумма элементов массива.
    ///
    /// Где писать: тело метода. Обязательно foreach.
    ///   [1,2,3,4] → 10    [] → 0
    /// </summary>
    public static int SumNumbers(int[] numbers)
    {
        // TODO: реализуй через foreach
        return 0;
    }

    /// <summary>
    /// ЗАДАЧА 3b. Только чётные числа (порядок сохранить).
    ///
    /// Где писать: тело метода. foreach + List&lt;int&gt; + ToArray().
    ///   [1,2,3,4,5,6] → [2,4,6]
    /// </summary>
    public static int[] GetEvenNumbers(int[] numbers)
    {
        // TODO: реализуй через foreach
        return [];
    }

    // ═══════════════════════════════════════════════════════════════════════
    // БЛОК 4. Цикл for
    // ───────────────────────────────────────────────────────────────────────
    // Пример:  Examples/04_For.cs
    // Тесты:   CountMultiples_Works, BuildSequence_Works
    // ═══════════════════════════════════════════════════════════════════════

    /// <summary>
    /// ЗАДАЧА 4a. Сколько элементов делятся на divisor без остатка.
    ///
    /// Где писать: тело метода. Классический for по индексу.
    ///   ([2,4,7,8], 2) → 3
    /// </summary>
    public static int CountMultiples(int[] numbers, int divisor)
    {
        // TODO: реализуй через for
        return 0;
    }

    /// <summary>
    /// ЗАДАЧА 4b. Массив [0, 1, 2, ..., count-1].
    ///
    /// Где писать: тело метода.
    ///   count=5 → [0,1,2,3,4]    count=0 → []
    /// </summary>
    public static int[] BuildSequence(int count)
    {
        // TODO: реализуй через for
        return [];
    }

    // ═══════════════════════════════════════════════════════════════════════
    // БЛОК 5. Цикл while
    // ───────────────────────────────────────────────────────────────────────
    // Пример:  Examples/05_While.cs
    // Тесты:   Factorial_Works, CountHalvingSteps_Works
    // ═══════════════════════════════════════════════════════════════════════

    /// <summary>
    /// ЗАДАЧА 5a. Факториал n! через while.
    ///
    /// Где писать: тело метода. Результат — long.
    ///   0! = 1    5! = 120    10! = 3628800
    /// </summary>
    public static long Factorial(int n)
    {
        // TODO: реализуй через while
        return 0;
    }

    /// <summary>
    /// ЗАДАЧА 5b. Сколько раз поделить number на 2, пока number &gt; threshold.
    ///
    /// Где писать: тело метода.
    ///   (20, 5) → 2   (20→10→5, дальше не делим)
    ///   (16, 1) → 4   (16→8→4→2→1)
    /// </summary>
    public static int CountHalvingSteps(int number, int threshold)
    {
        // TODO: реализуй через while
        return 0;
    }

    // ═══════════════════════════════════════════════════════════════════════
    // БЛОК 6. Value type vs Reference type
    // ───────────────────────────────────────────────────────────────────────
    // Пример:  Examples/06_ValueVsReference.cs
    // Типы:    Point (struct) и Player (class) — в конце этого файла
    // Тесты:   DoublePointX_*, AddBalance_*, SafeLength_*
    // ═══════════════════════════════════════════════════════════════════════

    /// <summary>
    /// ЗАДАЧА 6a. Удвоить X у точки (struct).
    ///
    /// Где писать: тело метода. Параметр уже ref — просто point.X *= 2.
    /// Без ref struct копируется и изменения теряются!
    /// </summary>
    public static void DoublePointX(ref Point point)
    {
        // TODO: реализуй
    }

    /// <summary>
    /// ЗАДАЧА 6b. Добавить amount к балансу игрока (class).
    ///
    /// Где писать: тело метода. player.Balance += amount;
    /// Class передаётся по ссылке — изменение видно снаружи.
    /// </summary>
    public static void AddBalance(Player player, int amount)
    {
        // TODO: реализуй
    }

    /// <summary>
    /// ЗАДАЧА 6c. Длина строки или 0 для null.
    ///
    /// Где писать: тело метода.
    ///   null → 0    "hello" → 5    "" → 0
    /// </summary>
    public static int SafeLength(string? text)
    {
        // TODO: реализуй
        return 0;
    }

    // ═══════════════════════════════════════════════════════════════════════
    // БЛОК 7. Pattern matching
    // ───────────────────────────────────────────────────────────────────────
    // Пример:  Examples/07_PatternMatching.cs
    // Тесты:   Describe_*, Grade_Works
    // ═══════════════════════════════════════════════════════════════════════

    /// <summary>
    /// ЗАДАЧА 7a. Описать значение через switch expression.
    ///
    /// Где писать: return-выражение ниже.
    ///   null        → "null"
    ///   int n       → "number:{n}"
    ///   ""          → "text:empty"
    ///   string s    → "text:{s}"
    ///   bool b      → "flag:{b}"
    ///   остальное   → "unknown"
    /// </summary>
    public static string Describe(object? value)
    {
        // TODO: реализуй (смотри Examples/07_PatternMatching.cs)
        return string.Empty;
    }

    /// <summary>
    /// ЗАДАЧА 7b. Оценка по баллам (0..100).
    ///
    /// Где писать: тело метода. if-else или switch.
    ///   90+ → A   75+ → B   60+ → C   40+ → D   иначе F
    ///   вне 0..100 → "invalid"
    /// </summary>
    public static string Grade(int score)
    {
        // TODO: реализуй
        return string.Empty;
    }
}

/// <summary>Value type (struct) — хранится на стеке, копируется при передаче.</summary>
public struct Point
{
    public int X;
    public int Y;

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
}

/// <summary>Reference type (class) — ссылка на объект в куче.</summary>
public class Player
{
    public int Balance { get; set; }

    public Player(int balance)
    {
        Balance = balance;
    }
}

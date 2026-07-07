namespace CsharpLecture2Practice.Examples;

/// <summary>
/// Пример к блоку 6: value type (struct) vs reference type (class).
/// Смотри перед DoublePointX, AddBalance, SafeLength.
/// </summary>
public static class ValueVsReferenceExample
{
    public static void Demo()
    {
        // ── struct (value type) — копируется ──
        var point = new DemoPoint(3, 7);
        TryDoubleXWithoutRef(point);
        Console.WriteLine($"Без ref: X = {point.X}"); // всё ещё 3

        DoubleXWithRef(ref point);
        Console.WriteLine($"С ref:   X = {point.X}"); // 6

        // ── class (reference type) — передаётся ссылка ──
        var player = new DemoPlayer(100);
        AddCoins(player, 50);
        Console.WriteLine($"Balance = {player.Balance}"); // 150

        // ── string — reference, но immutable ──
        var name = "Ann";
        var upper = ToUpper(name);
        Console.WriteLine($"name = {name}, upper = {upper}"); // Ann, ANN
    }

    public struct DemoPoint
    {
        public int X;
        public int Y;

        public DemoPoint(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    public class DemoPlayer
    {
        public int Balance { get; set; }

        public DemoPlayer(int balance) => Balance = balance;
    }

    // Без ref struct копируется — изменения не видны снаружи
    public static void TryDoubleXWithoutRef(DemoPoint point)
    {
        point.X *= 2;
    }

    // С ref меняем оригинал
    public static void DoubleXWithRef(ref DemoPoint point)
    {
        point.X *= 2;
    }

    public static void AddCoins(DemoPlayer player, int amount)
    {
        player.Balance += amount;
    }

    public static string ToUpper(string text)
    {
        // ToUpper возвращает НОВУЮ строку, исходная не меняется
        return text.ToUpperInvariant();
    }
}

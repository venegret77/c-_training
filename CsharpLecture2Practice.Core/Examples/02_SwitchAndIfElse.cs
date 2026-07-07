namespace CsharpLecture2Practice.Examples;

/// <summary>
/// Пример к блоку 2: switch expression и if-else (Rock Paper Scissors).
/// Смотри перед ChoiceToString и GetRoundResultText.
/// </summary>
public static class SwitchAndIfElseExample
{
    public static void Demo()
    {
        var userChoice = 1;
        var computerChoice = 3;

        Console.WriteLine($"You: {ChoiceToString(userChoice)}");
        Console.WriteLine($"PC:  {ChoiceToString(computerChoice)}");
        Console.WriteLine(GetRoundResultText(userChoice, computerChoice));
    }

    // switch expression — как на лекции для computerChoiceString
    public static string? ChoiceToString(int choice) => choice switch
    {
        1 => "Rock",
        2 => "Paper",
        3 => "Scissors",
        _ => null
    };

    // if-else — логика победы из лекции
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
}

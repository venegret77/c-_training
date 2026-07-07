namespace CsharpLecture2Practice.Examples;

/// <summary>
/// Фрагмент с лекции: Rock Paper Scissors (упрощённо, без while-меню).
/// Показывает связку ReadLine → TryParse → switch → if-else → Random.
/// Это НЕ задача — просто ориентир, откуда взяты блоки 1–2.
/// </summary>
public static class RockPaperScissorsLecture
{
    public static void RunSingleRound()
    {
        Console.WriteLine("Hello, this is Rock Paper Scissors");
        Console.WriteLine("Enter your step (1-Rock, 2-Paper, 3-Scissors, 0-Exit):");

        var userInput = Console.ReadLine();

        if (!int.TryParse(userInput, out var userChoice) || userChoice is < 0 or > 3)
        {
            Console.WriteLine("Invalid input");
            return;
        }

        if (userChoice == 0)
        {
            return;
        }

        var random = new Random();
        var computerChoice = random.Next(1, 4); // 1..3

        var userChoiceString = userChoice switch
        {
            1 => "Rock",
            2 => "Paper",
            _ => "Scissors"
        };

        var computerChoiceString = computerChoice switch
        {
            1 => "Rock",
            2 => "Paper",
            _ => "Scissors"
        };

        Console.WriteLine($"You chose {userChoiceString}");
        Console.WriteLine($"Computer chose {computerChoiceString}");

        if (computerChoice == userChoice)
        {
            Console.WriteLine("Draw");
        }
        else if ((userChoice == 1 && computerChoice == 3) ||
                 (userChoice == 2 && computerChoice == 1) ||
                 (userChoice == 3 && computerChoice == 2))
        {
            Console.WriteLine("You win");
        }
        else
        {
            Console.WriteLine("You lose");
        }
    }
}

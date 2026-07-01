namespace C.Training;

public class GameResult
{
    public Move PlayerMove { get; }
    public Move ComputerMove { get; }
    public string ResultText { get; }

    public GameResult(Move playerMove, Move computerMove, string resultText)
    {
        PlayerMove = playerMove;
        ComputerMove = computerMove;
        ResultText = resultText;
    }

    public void Print()
    {
        Console.WriteLine($"You: {PlayerMove.Name}");
        Console.WriteLine($"Computer: {ComputerMove.Name}");
        Console.WriteLine(ResultText);
    }

    public void Print(int roundNumber)
    {
        Console.WriteLine($"Round {roundNumber}");
        Console.WriteLine($"You: {PlayerMove.Name}");
        Console.WriteLine($"Computer: {ComputerMove.Name}");
        Console.WriteLine(ResultText);
    }
}

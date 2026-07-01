namespace C.Training;

public class Move
{
    public int Number { get; private set; }

    public string Name => Number switch
    {
        1 => "Rock",
        2 => "Paper",
        3 => "Scissors",
        _ => "Unknown"
    };

    public bool IsValid(int min = 1, int max = 3) => Number >= min && Number <= max;

    public void ReadFromConsole()
    {
        Console.WriteLine("1 - Rock, 2 - Paper, 3 - Scissors");

        var input = Console.ReadLine();
        Number = int.TryParse(input, out int number) ? number : 0;
    }

    public void GenerateRandom()
    {
        Number = Random.Shared.Next(1, 4);
    }
}

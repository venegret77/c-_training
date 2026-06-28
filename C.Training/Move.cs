namespace C.Training;

public class Move
{
    public int Number { get; private set; }
    public string Name { get; private set; }

    public void ReadFromConsole()
    {
        while (true)
        {
            Console.WriteLine("1 - Rock, 2 - Paper, 3 - Scissors");

            var input = Console.ReadLine();
            if (int.TryParse(input, out int number) && IsValid(number))
            {
                SetNumber(number);
                return;
            }

            Console.WriteLine("Invalid input");
        }
    }

    public void GenerateRandom()
    {
        SetNumber(Random.Shared.Next(1, 4)); // 1..3
    }

    private bool IsValid(int number)
    {
        return number >= 1 && number <= 3;
    }

    private void SetNumber(int number)
    {
        Number = number;
        Name = number switch
        {
            1 => "Rock",
            2 => "Paper",
            _ => "Scissors"
        };
    }
}
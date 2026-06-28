namespace C.Training;

public class Player
{
    public Player(string name)
    {
        Name = name;
    }

    public string Name { get; }

    public int Score { get; private set; } = 0;

    public void AddPoint()
    {
        Score++;
    }

    public void ResetScore()
    {
        Score = 0;
    }
}
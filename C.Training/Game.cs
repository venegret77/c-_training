namespace C.Training;

public class Game
{
    private int _roundsPlayed = 0;
    private int _roundsToPlay;

    public int RoundsToPlay
    {
        get { return _roundsToPlay; }
        set
        {
            if (value > 0 && value < 100)
            {
                _roundsToPlay = value;
            }
        }
    }

    public bool UserWon { get; private set; }

    public void Play()
    {
        var player = new Player("You");
        var computer = new Player("Computer");
        _roundsPlayed = 0;

        do
        {
            var playerMove = new Move();
            playerMove.ReadFromConsole();

            var computerMove = new Move();
            computerMove.GenerateRandom();

            string resultText;
            if (playerMove.Number == computerMove.Number)
            {
                resultText = "Draw";
            }
            else if (playerMove.Number == 1 && computerMove.Number == 3 ||
                     playerMove.Number == 2 && computerMove.Number == 1 ||
                     playerMove.Number == 3 && computerMove.Number == 2)
            {
                resultText = "You win this round";
                player.AddPoint();
            }
            else
            {
                resultText = "Computer wins this round";
                computer.AddPoint();
            }

            var result = new GameResult(playerMove, computerMove, resultText);
            result.Print();

            _roundsPlayed++;
        } while (_roundsPlayed < RoundsToPlay);

        UserWon = player.Score > computer.Score;
        Console.WriteLine($"Score — You: {player.Score}, Computer: {computer.Score}");
    }
}
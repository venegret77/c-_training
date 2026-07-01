namespace C.Training;

public class Game
{
    private readonly Player _player;
    private readonly Player _computer;
    private readonly int _roundsToPlay;
    private int _roundsPlayed;

    public Game(Player player, Player computer, int roundsToPlay)
    {
        _player = player;
        _computer = computer;
        _roundsToPlay = roundsToPlay;
    }

    public void Play()
    {
        _roundsPlayed = 0;
        _player.ResetScore();
        _computer.ResetScore();

        while (_roundsPlayed < _roundsToPlay)
        {
            var playerMove = new Move();
            playerMove.ReadFromConsole();

            if (!playerMove.IsValid())
            {
                Console.WriteLine("Invalid move. Try again.");
                continue;
            }

            var computerMove = new Move();
            computerMove.GenerateRandom();

            _roundsPlayed++;
            var result = PlayRound(playerMove, computerMove);
            result.Print(_roundsPlayed);
            PrintScore();
        }

        PrintFinalResult();
    }

    public GameResult PlayRound(Move playerMove, Move computerMove)
    {
        string resultText;

        if (playerMove.Number == computerMove.Number)
        {
            resultText = "Draw";
        }
        else if (playerMove.Number == 1 && computerMove.Number == 3 ||
                 playerMove.Number == 2 && computerMove.Number == 1 ||
                 playerMove.Number == 3 && computerMove.Number == 2)
        {
            resultText = $"{_player.Name} wins this round";
            _player.AddPoint();
        }
        else
        {
            resultText = $"{_computer.Name} wins this round";
            _computer.AddPoint();
        }

        return new GameResult(playerMove, computerMove, resultText);
    }

    private void PrintScore()
    {
        Console.WriteLine($"Score — {_player.Name}: {_player.Score}, {_computer.Name}: {_computer.Score}");
    }

    private void PrintFinalResult()
    {
        Console.WriteLine($"Final score — {_player.Name}: {_player.Score}, {_computer.Name}: {_computer.Score}");

        if (_player.Score == _computer.Score)
        {
            Console.WriteLine("Draw!");
        }
        else if (_player.Score > _computer.Score)
        {
            Console.WriteLine($"Winner: {_player.Name}");
        }
        else
        {
            Console.WriteLine($"Winner: {_computer.Name}");
        }
    }
}

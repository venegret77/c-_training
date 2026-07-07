class Program
{
    public static void Main()
    {
        var shipPosition = new Position(2, 1);
        var ship = new Ship(shipPosition, 2);
        var board = new Board(5, 5, ship);
        var game = new Game();
        game.Play(board);
    }
}

class Position
{
    public int X { get; set; }
    public int Y { get; }
    public Position(int x, int y)
    {
        X = x;
        Y = y;
    }
}

class Ship
{
    public Position Position { get; }
    public int Length { get; }
    public Ship(Position position, int length)
    {
        Position = position;
        Length = length;
    }
}

class Board
{
    public int Rows { get; }
    public int Columns { get; }
    public Ship Ship { get; }
    public Board(int rows, int columns, Ship ship)
    {
        Rows = rows;
        Columns = columns;
        Ship = ship;
    }
    public bool IsInside(Position position)
    {
        return position.X >= 0 && position.X < Rows && position.Y >= 0 && position.Y < Columns;
    }
    public bool HasShip(Position position)
    {
        return position.Y == Ship.Position.Y && position.X >= Ship.Position.X &&
               position.X < Ship.Position.X + Ship.Length;
    }
}

class Game
{
    public int UserHitsCount { get; private set; }
    public int ComputerHitsCount { get; private set; }

    public void Play(Board board)
    {
        var opponentBoard = GenerateOpponentBoard(board.Rows, board.Columns);
        var random = new Random();

        var roundCount = 0;
        while (true)
        {
            if (!TryReadFromConsole("X", roundCount, out var xPosition))
                continue;
            Console.WriteLine();
            if (!TryReadFromConsole("Y", roundCount, out var yPosition))
                continue;

            var userShotPosition = new Position(xPosition, yPosition);
            if (!opponentBoard.IsInside(userShotPosition))
            {
                Console.WriteLine("Invalid shot position!");
                continue;
            }

            if (opponentBoard.HasShip(userShotPosition))
            {
                Console.WriteLine("Hit!");
                UserHitsCount++;
            }
            else
            {
                Console.WriteLine("Miss!");
            }

            var computerX = random.Next(0, board.Rows);
            var computerY = random.Next(0, board.Columns);
            var computerShotPosition = new Position(computerX, computerY);

            Console.WriteLine($"Computer shoots at ({computerX}, {computerY})");

            if (board.HasShip(computerShotPosition))
            {
                Console.WriteLine("Computer hit!");
                ComputerHitsCount++;
            }
            else
            {
                Console.WriteLine("Computer missed!");
            }

            Console.WriteLine($"Score - You: {UserHitsCount}, Computer: {ComputerHitsCount}");
            Console.WriteLine();
            roundCount++;
        }
    }

    private Board GenerateOpponentBoard(int rows, int columns)
    {
        var random = new Random();
        var length = random.Next(1, 4);
        var x = random.Next(0, rows - length + 1);
        var y = random.Next(0, columns);

        var position = new Position(x, y);
        var ship = new Ship(position, length);

        return new Board(rows, columns, ship);
    }

    private bool TryReadFromConsole(string coordinateName, int roundCount, out int coordinate)
    {
        Console.WriteLine($"Input your {coordinateName} coordinate for round {roundCount}:");
        var input = Console.ReadLine();
        if (!int.TryParse(input, out coordinate))
        {
            Console.WriteLine("Invalid input");
            return false;
        }

        return true;
    }
}
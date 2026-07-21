class Program
{
    public static void Main()
    {
        var settings = new GameSettings(minShipLength: 1, maxShipLength: 3);
        var ships = new Ship[]
        {
            new HorizontalShip(new Position(0, 0), 2),
            new VerticalShip(new Position(2, 2), 3),
        };
        var board = new Board(5, 5, ships);
        IPlayer human = new HumanPlayer("Игрок", board);
        var game = new Game(settings);
        game.Play(human);
    }
}

readonly struct Position
{
    public int X { get; }
    public int Y { get; }

    public Position(int x, int y)
    {
        if (x < 0 || y < 0)
            throw new ArgumentException($"Координаты не могут быть отрицательными: ({x}, {y})");

        X = x;
        Y = y;
    }

    public override string ToString() => $"({X}, {Y})";
}

enum ShootResult
{
    Miss,
    Hit
}

record Shot(Board Board, Position Position, Ship? Ship)
{
    public ShootResult Result => Ship is null ? ShootResult.Miss : ShootResult.Hit;
}

abstract class Ship
{
    private readonly List<Shot> _hits = new();

    public Position Position { get; }
    public int Length { get; }
    public IReadOnlyList<Shot> Hits => _hits;
    public bool IsSunk => _hits.Count >= Length;

    protected Ship(Position position, int length)
    {
        if (length <= 0)
            throw new ArgumentException("Длина корабля должна быть положительной", nameof(length));

        Position = position;
        Length = length;
    }

    public abstract bool IsOnPosition(Position position);

    public abstract bool Intersects(Ship other);

    public void AddHit(Shot shot) => _hits.Add(shot);

    public override string ToString() => $"{GetType().Name} в {Position}, длина {Length}";
}

class HorizontalShip : Ship
{
    public HorizontalShip(Position position, int length) : base(position, length)
    {
    }

    public override bool IsOnPosition(Position position)
    {
        return position.X == Position.X
               && position.Y >= Position.Y
               && position.Y < Position.Y + Length;
    }

    public override bool Intersects(Ship other)
    {
        for (var i = 0; i < Length; i++)
        {
            var position = new Position(Position.X, Position.Y + i);
            if (other.IsOnPosition(position))
                return true;
        }

        return false;
    }
}

class VerticalShip : Ship
{
    public VerticalShip(Position position, int length) : base(position, length)
    {
    }

    public override bool IsOnPosition(Position position)
    {
        return position.Y == Position.Y
               && position.X >= Position.X
               && position.X < Position.X + Length;
    }

    public override bool Intersects(Ship other)
    {
        for (var i = 0; i < Length; i++)
        {
            var position = new Position(Position.X + i, Position.Y);
            if (other.IsOnPosition(position))
                return true;
        }

        return false;
    }
}

class Board
{
    public int Rows { get; }
    public int Columns { get; }
    public Ship[] Ships { get; }

    public Board(int rows, int columns, Ship[] ships)
    {
        if (rows <= 0 || columns <= 0)
            throw new ArgumentException($"Некорректный размер доски: {rows}x{columns}");

        if (ships is null || ships.Length == 0)
            throw new ArgumentException("На доске должен быть хотя бы один корабль");

        Rows = rows;
        Columns = columns;

        foreach (var ship in ships)
        {
            if (!IsShipInside(ship))
                throw new ArgumentException($"Корабль {ship} выходит за пределы поля {rows}x{columns}");
        }

        for (var i = 0; i < ships.Length; i++)
        {
            for (var j = i + 1; j < ships.Length; j++)
            {
                if (ships[i].Intersects(ships[j]))
                    throw new ArgumentException($"Корабли пересекаются: {ships[i]} и {ships[j]}");
            }
        }

        Ships = ships;
    }

    public bool IsInside(Position position)
    {
        return position.X >= 0 && position.X < Rows && position.Y >= 0 && position.Y < Columns;
    }

    public Ship? FindShip(Position position)
    {
        return Ships.FirstOrDefault(ship => ship.IsOnPosition(position));
    }

    private bool IsShipInside(Ship ship)
    {
        var cellsOnBoard = 0;
        for (var x = 0; x < Rows; x++)
        {
            for (var y = 0; y < Columns; y++)
            {
                if (ship.IsOnPosition(new Position(x, y)))
                    cellsOnBoard++;
            }
        }

        return cellsOnBoard == ship.Length;
    }
}

class GameSettings
{
    public int MinShipLength { get; }
    public int MaxShipLength { get; }

    public GameSettings(int minShipLength, int maxShipLength)
    {
        if (minShipLength <= 0)
            throw new ArgumentException("Минимальная длина корабля должна быть положительной", nameof(minShipLength));
        if (maxShipLength < minShipLength)
            throw new ArgumentException("Максимальная длина не может быть меньше минимальной", nameof(maxShipLength));

        MinShipLength = minShipLength;
        MaxShipLength = maxShipLength;
    }
}

static class RandomExtensions
{
    public static Ship NextShip(this Random random, GameSettings settings, int rows, int columns)
    {
        var length = random.Next(settings.MinShipLength, settings.MaxShipLength + 1);
        var isHorizontal = random.Next(2) == 0;

        if (isHorizontal)
        {
            if (length > columns)
                throw new ArgumentException($"Корабль длины {length} не помещается на поле шириной {columns}");

            var x = random.Next(0, rows);
            var y = random.Next(0, columns - length + 1);
            return new HorizontalShip(new Position(x, y), length);
        }

        if (length > rows)
            throw new ArgumentException($"Корабль длины {length} не помещается на поле высотой {rows}");

        var verticalX = random.Next(0, rows - length + 1);
        var verticalY = random.Next(0, columns);
        return new VerticalShip(new Position(verticalX, verticalY), length);
    }
}

interface IShooter
{
    Shot Shoot(Board targetBoard);
}

interface IPlayer : IShooter
{
    string Name { get; }
    Board Board { get; }
}

class HumanPlayer : IPlayer
{
    public string Name { get; }
    public Board Board { get; }

    public HumanPlayer(string name, Board board)
    {
        Name = name;
        Board = board;
    }

    public Shot Shoot(Board targetBoard)
    {
        var x = ReadCoordinate("X");
        var y = ReadCoordinate("Y");
        var position = new Position(x, y);
        var ship = targetBoard.FindShip(position);
        return new Shot(targetBoard, position, ship);
    }

    private static int ReadCoordinate(string coordinateName)
    {
        Console.WriteLine($"Введите координату {coordinateName}:");
        var input = Console.ReadLine();
        if (!int.TryParse(input, out var coordinate))
            throw new FormatException($"Некорректный ввод координаты {coordinateName}");

        return coordinate;
    }
}

class ComputerPlayer : IPlayer
{
    private readonly Random _random = new();

    public string Name { get; }
    public Board Board { get; }

    public ComputerPlayer(string name, Board board)
    {
        Name = name;
        Board = board;
    }

    public Shot Shoot(Board targetBoard)
    {
        var position = new Position(_random.Next(0, targetBoard.Rows), _random.Next(0, targetBoard.Columns));
        var ship = targetBoard.FindShip(position);
        return new Shot(targetBoard, position, ship);
    }
}

class Game
{
    public GameSettings Settings { get; }
    public List<Shot> Shots { get; } = new();

    public Game(GameSettings settings)
    {
        Settings = settings ?? throw new ArgumentNullException(nameof(settings));
    }

    public void Play(IPlayer player)
    {
        var opponentBoard = GenerateOpponentBoard(player.Board);
        IPlayer opponent = new ComputerPlayer("Компьютер", opponentBoard);

        while (true)
        {
            var playerShot = TakeShot(player, opponent.Board);
            PrintShotResult(player.Name, playerShot);

            var opponentShot = TakeShot(opponent, player.Board);
            PrintShotResult(opponent.Name, opponentShot);

            Console.WriteLine();
            Console.WriteLine($"Доска {player.Name}:");
            PrintBoard(player.Board, revealShips: true);

            Console.WriteLine($"Доска {opponent.Name}:");
            PrintBoard(opponent.Board, revealShips: false);

            var sunkOnPlayerBoard = player.Board.Ships.Count(ship => ship.IsSunk);
            var sunkOnOpponentBoard = opponent.Board.Ships.Count(ship => ship.IsSunk);
            Console.WriteLine($"Потопленных кораблей у {player.Name}: {sunkOnPlayerBoard}");
            Console.WriteLine($"Потопленных кораблей у {opponent.Name}: {sunkOnOpponentBoard}");
            Console.WriteLine();

            if (opponent.Board.Ships.All(ship => ship.IsSunk))
            {
                Console.WriteLine($"Победитель: {player.Name}!");
                break;
            }

            if (player.Board.Ships.All(ship => ship.IsSunk))
            {
                Console.WriteLine($"Победитель: {opponent.Name}!");
                break;
            }
        }
    }

    private Shot TakeShot(IPlayer shooter, Board targetBoard)
    {
        while (true)
        {
            try
            {
                var shot = shooter.Shoot(targetBoard);

                if (!targetBoard.IsInside(shot.Position))
                    throw new ArgumentOutOfRangeException(nameof(shot.Position), "Позиция выстрела за пределами доски!");

                if (Shots.Any(existing => existing.Board == targetBoard && existing.Position.Equals(shot.Position)))
                    throw new InvalidOperationException("В эту клетку уже стреляли!");

                Shots.Add(shot);
                shot.Ship?.AddHit(shot);
                return shot;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    private static void PrintShotResult(string shooterName, Shot shot)
    {
        Console.WriteLine($"{shooterName} стреляет в {shot.Position}");
        Console.WriteLine(shot.Result == ShootResult.Hit ? "Попадание!" : "Мимо!");
    }

    private void PrintBoard(Board board, bool revealShips)
    {
        for (var x = 0; x < board.Rows; x++)
        {
            for (var y = 0; y < board.Columns; y++)
            {
                var position = new Position(x, y);
                var shot = Shots.FirstOrDefault(s => s.Board == board && s.Position.Equals(position));

                char cell;
                if (shot is not null)
                    cell = shot.Result == ShootResult.Hit ? 'X' : 'O';
                else if (revealShips && board.FindShip(position) is not null)
                    cell = 'S';
                else
                    cell = '.';

                Console.Write(cell);
                Console.Write(' ');
            }

            Console.WriteLine();
        }
    }

    private Board GenerateOpponentBoard(Board userBoard)
    {
        var random = new Random();
        var ships = new List<Ship>();

        for (var i = 0; i < userBoard.Ships.Length; i++)
        {
            Ship candidate;
            do
            {
                candidate = random.NextShip(Settings, userBoard.Rows, userBoard.Columns);
            }
            while (ships.Any(existing => existing.Intersects(candidate)));

            ships.Add(candidate);
        }

        return new Board(userBoard.Rows, userBoard.Columns, ships.ToArray());
    }
}

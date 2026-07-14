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

class Ship
{
    public Position Position { get; }
    public int Length { get; }

    public Ship(Position position, int length)
    {
        if (position == null)
            throw new ArgumentNullException(nameof(position));
        if (length <= 0)
            throw new ArgumentException("Длина корабля должна быть положительной", nameof(length));

        Position = position;
        Length = length;
    }

    public override string ToString() => $"Корабль в {Position}, длина {Length}";
}

class Board
{
    public int Rows { get; }
    public int Columns { get; }
    public IReadOnlyList<Ship> Ships { get; }

    public Board(int rows, int columns, IEnumerable<Ship> ships)
    {
        if (rows <= 0 || columns <= 0)
            throw new ArgumentException($"Некорректный размер доски: {rows}x{columns}");

        if (ships == null)
            throw new ArgumentNullException(nameof(ships));

        var shipList = ships.ToList();
        if (shipList.Count == 0)
            throw new ArgumentException("На доске должен быть хотя бы один корабль");

        Rows = rows;
        Columns = columns;

        foreach (var s in shipList)
        {
            if (s.Position.X < 0 || s.Position.Y < 0 ||
                s.Position.X + s.Length - 1 >= rows || s.Position.Y >= columns)
            {
                throw new ArgumentException(
                    $"Корабль {s} выходит за пределы поля {rows}x{columns}");
            }
        }

        Ships = shipList;
    }

    public Board(int rows, int columns, Ship ship) : this(rows, columns, new[] { ship })
    {
    }

    public bool IsInside(Position position)
    {
        return position.X >= 0 && position.X < Rows && position.Y >= 0 && position.Y < Columns;
    }

    public Ship? FindShip(Position position)
    {
        return Ships.FirstOrDefault(ship =>
            position.Y == ship.Position.Y &&
            position.X >= ship.Position.X &&
            position.X < ship.Position.X + ship.Length);
    }
}

class Shot
{
    public Board Board { get; }
    public Position Position { get; }
    public Ship? Ship { get; }

    public Shot(Board board, Position position, Ship? ship)
    {
        Board = board ?? throw new ArgumentNullException(nameof(board));
        Position = position ?? throw new ArgumentNullException(nameof(position));
        Ship = ship;
    }

    public bool IsHit => Ship != null;
}

class Game
{
    public int UserHitsCount { get; private set; }
    public int ComputerHitsCount { get; private set; }
    public List<Shot> Shots { get; } = new();

    public void Play(Board board)
    {
        var opponentBoard = GenerateOpponentBoard(board.Rows, board.Columns);
        var random = new Random();
        var boards = new[] { board, opponentBoard };

        var roundCount = 0;
        while (true)
        {
            Position userShotPosition;
            try
            {
                if (!TryReadFromConsole("X", roundCount, out var xPosition))
                    continue;
                Console.WriteLine();
                if (!TryReadFromConsole("Y", roundCount, out var yPosition))
                    continue;

                userShotPosition = new Position(xPosition, yPosition);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                continue;
            }

            Shot userShot;
            try
            {
                userShot = MakeShot(opponentBoard, userShotPosition);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                continue;
            }

            if (userShot.IsHit)
            {
                Console.WriteLine("Hit!");
                UserHitsCount++;
            }
            else
            {
                Console.WriteLine("Miss!");
            }

            var computerShot = MakeComputerShot(board, random);
            Console.WriteLine($"Computer shoots at {computerShot.Position}");

            if (computerShot.IsHit)
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

            PrintStatistics(board, "вашей доске (обороне)");
            PrintStatistics(opponentBoard, "доске противника (атаке)");
            Console.WriteLine();

            roundCount++;
        }
    }

    private Shot MakeShot(Board targetBoard, Position position)
    {
        if (!targetBoard.IsInside(position))
            throw new ArgumentOutOfRangeException(nameof(position), "Позиция выстрела за пределами доски!");

        if (Shots.Any(s => s.Board == targetBoard && s.Position.X == position.X && s.Position.Y == position.Y))
            throw new InvalidOperationException("Вы уже стреляли в эту клетку!");

        var ship = targetBoard.FindShip(position);
        var shot = new Shot(targetBoard, position, ship);
        Shots.Add(shot);
        return shot;
    }

    private Shot MakeComputerShot(Board targetBoard, Random random)
    {
        while (true)
        {
            var position = new Position(random.Next(0, targetBoard.Rows), random.Next(0, targetBoard.Columns));
            try
            {
                return MakeShot(targetBoard, position);
            }
            catch (InvalidOperationException)
            {
            }
        }
    }

    private void PrintStatistics(Board targetBoard, string boardName)
    {
        var shotsOnBoard = Shots.Where(s => s.Board == targetBoard).ToList();

        var totalShots = shotsOnBoard.Count;
        var hitsCount = shotsOnBoard.Count(s => s.IsHit);
        var missesCount = shotsOnBoard.Count(s => !s.IsHit);
        var hasMiss = shotsOnBoard.Any(s => !s.IsHit);
        var firstHit = shotsOnBoard.FirstOrDefault(s => s.IsHit);
        var hitCoordinates = shotsOnBoard.Where(s => s.IsHit).Select(s => s.Position).ToList();

        Console.WriteLine($"--- Статистика по {boardName} ---");
        Console.WriteLine($"Всего выстрелов: {totalShots}");
        Console.WriteLine($"Попаданий: {hitsCount}");
        Console.WriteLine($"Промахов: {missesCount}");
        Console.WriteLine($"Был хотя бы один промах: {(hasMiss ? "да" : "нет")}");
        Console.WriteLine(firstHit != null
            ? $"Первое попадание: {firstHit.Position}"
            : "Первое попадание: ещё не было");
        Console.WriteLine(hitCoordinates.Count > 0
            ? $"Координаты попаданий: {string.Join(", ", hitCoordinates)}"
            : "Координаты попаданий: нет");

        foreach (var ship in targetBoard.Ships)
        {
            var shipHits = Shots.Count(s => s.Board == targetBoard && s.Ship == ship);
            var isSunk = shipHits >= ship.Length;
            Console.WriteLine($"{ship}: попаданий {shipHits}/{ship.Length} — {(isSunk ? "потоплен" : "на плаву")}");
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
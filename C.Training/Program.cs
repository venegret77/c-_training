using C.Training;

TryWriteLine(nameof(BasicTasks.SayHello), () => BasicTasks.SayHello());
TryWriteLine(nameof(BasicTasks.FormatPerson), () => BasicTasks.FormatPerson("Михаил", 25));
TryWriteLine(nameof(BasicTasks.Sum), () => BasicTasks.Sum(2, 3));
TryWriteLine(nameof(BasicTasks.Square), () => BasicTasks.Square(4));
TryWriteLine(nameof(BasicTasks.IsEven), () => BasicTasks.IsEven(4));
TryWriteLine(nameof(BasicTasks.IsEven), () => BasicTasks.IsEven(5));
TryWriteLine(nameof(BasicTasks.SumToN), () => BasicTasks.SumToN(5));

static void TryWriteLine<T>(string name, Func<T> func)
{
    try
    {
        var result = func();
        Console.WriteLine($"{name} => {result}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"{name} => ERROR: {ex.GetType().Name} - {ex.Message}");
    }
}
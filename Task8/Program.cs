// ============================================================
// ЗАДАЧА 8: Чётное/нечётное — выносим логику в методы
// Что учим: методы, параметры, возврат значений, ref
// Связь с задачей 3
// ============================================================
// Вынеси проверку чётности в метод.
// Счётчики передавай через ref — метод сам их увеличивает.
 
// TODO: bool IsEven(int number) — возвращает true если чётное
 
// TODO: void UpdateCounters(int number, ref int even, ref int odd)
// внутри вызывает IsEven и увеличивает нужный счётчик
 
// TODO: перепиши цикл из задачи 3, используя UpdateCounters

Console.WriteLine("Задача 8.");
bool Numb(int chislo)
{
    return chislo % 2 == 0;
}
int[] mass = new int[5];
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Введите 5 чисел");
    var zahl = Console.ReadLine();
    bool confirmzahl = int.TryParse(zahl, out int chislo);
    while (confirmzahl == false)
    {
        Console.WriteLine("Неверный ввод");
        Console.WriteLine("Повторно введите число");
        zahl = Console.ReadLine();
        confirmzahl = int.TryParse(zahl, out chislo);
    }
    bool numbResult = Numb(chislo);
    if (numbResult == true)
    {
        Console.WriteLine("Это число четное");
    }
    else
    {
        Console.WriteLine("Это число нечетное");
    }
    mass[i] = chislo;
}
int chet = 0;
int nech = 0;
foreach (var zahl in mass)
{
    Console.WriteLine(zahl);
    bool numbResult = Numb(zahl);
    if (numbResult == true)
    {
        chet++;
    }
    else
    {
        nech++;
    }
}

Console.WriteLine($"Четных чисел: {chet}, нечетных чисел: {nech}");



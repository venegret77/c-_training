// ============================================================
// ЗАДАЧА 3: Чётное или нечётное
// Что учим: TryParse, логические операторы (%), if/else, циклы
// ============================================================
// Пользователь вводит 5 чисел подряд.
// Для каждого программа говорит: чётное или нечётное.
// В конце выводит сколько было чётных и сколько нечётных.

Console.WriteLine("Задача 3.");
/*int[]mass = new int[5];
Console.WriteLine("Введите 5 чисел");
var eins = Console.ReadLine();
bool confirmeins = int.TryParse(eins, out int one);
while (confirmeins == false)
{
    Console.WriteLine("Неверный ввод");
    Console.WriteLine("Повторно введите число");
    eins = Console.ReadLine();
    confirmeins = int.TryParse(eins, out one);
}
if (one % 2 == 0)
{
    Console.WriteLine("Это четное число");
}
else
{
    Console.WriteLine("Это нечетное число");
}
mass[0] = one;
var zwei  = Console.ReadLine();
bool confirmzwei = int.TryParse(zwei, out int two);
while (confirmzwei == false)
{
    Console.WriteLine("Неверный ввод");
    Console.WriteLine("Повторно введите число");
    zwei = Console.ReadLine();
    confirmzwei = int.TryParse(zwei, out two);
}
if (two % 2 == 0)
{
    Console.WriteLine("Это четное число");
}
else
{
    Console.WriteLine("Это нечетное число");
}
mass[1] = two;
var drei = Console.ReadLine();
bool confirmdrei = int.TryParse(drei, out int three);
while (confirmdrei == false)
{
    Console.WriteLine("Неверный ввод");
    Console.WriteLine("Повторно введите число");
    drei = Console.ReadLine();
    confirmdrei = int.TryParse(drei, out three);
}
if (three % 2 == 0)
{
    Console.WriteLine("Это четное число");
}
else
{
    Console.WriteLine("Это нечетное число");
}
mass[2] = three;
var vier = Console.ReadLine();
bool confirmvier = int.TryParse(vier, out int thoar);
while (confirmvier == false)
{
    Console.WriteLine("Неверный ввод");
    Console.WriteLine("Повторно введите число");
    vier = Console.ReadLine();
    confirmvier = int.TryParse(vier, out thoar);
}
if (thoar % 2 == 0)
{
    Console.WriteLine("Это четное число");
}
else
{
    Console.WriteLine("Это нечетное число");
}
mass[3] = thoar;
var funf = Console.ReadLine();
bool confirmfunf = int.TryParse(funf, out int fife);
while (confirmfunf == false)
{
    Console.WriteLine("Неверный ввод");
    Console.WriteLine("Повторно введите число");
    funf = Console.ReadLine();
    confirmfunf = int.TryParse(funf, out fife);
}
if (fife % 2 == 0)
{
    Console.WriteLine("Это четное число");
}
else
{
    Console.WriteLine("Это нечетное число");
}
mass[4] = fife;
int chet = 0;
int nech = 0;
foreach (var zahl in mass)
{
    Console.WriteLine(zahl);
    if (zahl % 2 == 0)
    {
        chet++;
    }
    else
    {
        nech++;
    }
}
Console.WriteLine($"Четных чисел: {chet}, нечетных чисел: {nech}");*/
int[] mass = new int[5];
for (int i = 0; i<5; i++)
{
    Console.WriteLine("Введите 5 чисел");
    var zahl  = Console.ReadLine();
    bool confirmzahl= int.TryParse(zahl, out int chislo);
    while (confirmzahl== false)
    {
        Console.WriteLine("Неверный ввод");
        Console.WriteLine("Повторно введите число");
        zahl = Console.ReadLine();
        confirmzahl = int.TryParse(zahl, out chislo);

    }
    if (chislo % 2 == 0)
    {
        Console.WriteLine("Это четное число");
    }
    else
    {
        Console.WriteLine("Это нечетное число");
    }
    mass[i] = chislo;
}
int chet = 0;
int nech = 0;
foreach (var zahl in mass)
{
    Console.WriteLine(zahl);
    if (zahl % 2 == 0)
    {
        chet++;
    }
    else
    {
        nech++;
    }
}
Console.WriteLine($"Четных чисел: {chet}, нечетных чисел: {nech}");
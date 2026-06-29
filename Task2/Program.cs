// ============================================================
// ЗАДАЧА 2: Простой калькулятор
// Что учим: switch, TryParse, условия (if/else)
// ============================================================
// Пользователь вводит первое число, знак операции (+, -, *, /),
// потом второе число. Программа выводит результат.
// Деление на ноль обработать отдельно.

Console.WriteLine("Задача 2.");
Console.WriteLine("Введите число");
var inputzahl = Console.ReadLine();
bool number = int.TryParse(inputzahl, out int result);
while (number == false)
{
    Console.WriteLine("Неверный ввод");
    Console.WriteLine("Введите число");
    inputzahl = Console.ReadLine();
    number = int.TryParse(inputzahl, out result);

}
Console.WriteLine("Введите операцию");
var inputSymbol = Console.ReadLine();
while (!(inputSymbol == "*" || inputSymbol == "/" || inputSymbol == "+" || inputSymbol == "-"))
{
    Console.WriteLine("Неверный ввод");
    Console.WriteLine("Введите операцию");
    inputSymbol = Console.ReadLine();
}
Console.WriteLine("Введите второе число");
var inputzahl2 = Console.ReadLine();
bool number2 = int.TryParse(inputzahl2, out int result2);
while (number2 == false)
{
    Console.WriteLine("Неверный ввод");
    Console.WriteLine("Введите второе число");
     inputzahl2 = Console.ReadLine();
    number2 = int.TryParse(inputzahl2, out result2);
}
if (result2 == 0 && inputSymbol == "/")
{
    Console.WriteLine("Ошибка.Деление на ноль запрещено!");
}
else if (inputSymbol == "+")
{
    int summ = result + result2;
    Console.WriteLine($"Сумма чисел равна {summ}");
}
else if (inputSymbol == "-")
{
    int vich = result - result2;
    Console.WriteLine($"Разница чисел равна {vich}");
}
else if (inputSymbol == "*")
{
    int umn = result * result2;
    Console.WriteLine($"Произведение чисел равно {umn}");
}
else if (inputSymbol == "/")
{
    double del = (double)result / (double)result2;
    Console.WriteLine($"Деление чисел равно {del}");
}
     
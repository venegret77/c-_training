// ============================================================
// ЗАДАЧА 7: Калькулятор — выносим операции в методы с перегрузкой
// Что учим: методы, возврат значений, перегрузка
// Связь с задачей 2
// ============================================================
// Возьми задачу 2 и вынеси каждую операцию в отдельный метод.
// Добавь перегрузку: каждый метод работает и с int, и с double.
 
// TODO: int Add(int a, int b)
// TODO: double Add(double a, double b)
// (аналогично Subtract, Multiply)
 
// TODO: метод Divide отдельный:
// double Divide(int a, int b) — возвращает double
// если b == 0 — можно вернуть double.NaN и проверить снаружи
 
// TODO: перепиши switch из задачи 2, вызывая эти методы

Console.WriteLine("Задача 7.");

Console.WriteLine("Введите число");
string inputzahl = Console.ReadLine();
bool number = double.TryParse(inputzahl, out double result);
while (number == false)
{
    Console.WriteLine("Неверный ввод");
    Console.WriteLine("Введите число");
    inputzahl = Console.ReadLine();
    number = double.TryParse(inputzahl, out result);

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
string inputzahl2 = Console.ReadLine();
bool number2 = double.TryParse(inputzahl2, out double result2);
while (number2 == false)
{
    Console.WriteLine("Неверный ввод");
    Console.WriteLine("Введите второе число");
    inputzahl2 = Console.ReadLine();
    number2 = double.TryParse(inputzahl2, out result2);
}
if (result2 == 0 && inputSymbol == "/")
{
    Console.WriteLine("Ошибка.Деление на ноль запрещено!");
}
else if (inputSymbol == "+")
{
    double Summ(double result, double result2)
    {
        return result + result2;
    }
    double isSummResult = Summ(result, result2);
    Console.WriteLine($"Сумма чисел равна {isSummResult}");
}
else if (inputSymbol == "-")
{
    double Difference(double result, double result2)
    {
        return result - result2;
    }
    double differenceResult = Difference(result, result2);
    Console.WriteLine($"Разница чисел равна {differenceResult}");
}
else if (inputSymbol == "*")
{
    double Product(double result, double result2)
    {
        return result * result2;
    }
    double productResult = Product(result, result2);
    Console.WriteLine($"Произведение чисел равно {productResult}");
}
else if (inputSymbol == "/")
{
    double Division(double result, double result2)
    {
        return result / result2;
    }
    double divisionResult = Division(result, result2);
    Console.WriteLine($"Частное чисел равно {divisionResult}");
}













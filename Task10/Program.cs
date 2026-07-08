// ============================================================
// ЗАДАЧА 10: Банкомат — переписываем через класс
// Что учим: классы, конструктор, свойства (get, private set), методы
// Связь с задачей 5
// ============================================================
// Создай класс BankAccount.
// Свойство Balance — только get снаружи (менять только через методы).
// Конструктор принимает начальный баланс.
// Методы Deposit и Withdraw с проверками.
// Метод PrintBalance выводит текущий баланс.
// Перепиши меню из задачи 5, используя объект класса.
 
// TODO: class BankAccount
// {
//     public decimal Balance { get; private set; }
//
//     TODO: конструктор BankAccount(decimal initialBalance)
//     проверь что initialBalance >= 0, иначе выбрось ArgumentException
//
//     TODO: void Deposit(decimal amount)
//     проверь amount > 0
//     Balance += amount
//
//     TODO: void Withdraw(decimal amount)
//     проверь amount > 0 && amount <= Balance
//     Balance -= amount
//
//     TODO: void PrintBalance()
//     вывести "Баланс: {Balance} руб."
// }
 
// TODO: создай объект: var account = new BankAccount(1000);
// TODO: перепиши цикл меню из задачи 5, вызывая методы account

using System.Runtime.CompilerServices;

Console.WriteLine("Задача 10.");

/*int a = 0;
int b = 5;
int c;
try
{
    c = b / a;
}
catch (Exception ex)
{
    Console.WriteLine($"Системная ошибка: {ex.Message}");
    Console.WriteLine("Мандавошка, прекратили дележку! Делить на ноль нельзя! Нельзя!");
}*/
/*try
{
int [] mass = new int [3] {1,2,3};
Console.WriteLine(mass[10]);
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine($" Системная ошибка: {ex.Message}");
    Console.WriteLine("Нет такого элемента!");
}*/
/*void CheckAge(int age)
{
    if (age < 0)
        throw new ArgumentException("Ты еще же даже не родился!");
}
try
{
    CheckAge(25);
    CheckAge(-5);
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Системная ошибка: {ex.Message}");
}*/
try
{
    var a = Console.ReadLine();
    bool b = int.TryParse(a, out int result);
    int itog = 100 / result;
    Console.WriteLine($"Результат {itog}");
}
catch (Exception ex)
{
    Console.WriteLine($"Системная ошибка: {ex.Message}");
}
finally
{
    Console.WriteLine("Программа завершена");
}
// ============================================================
// ЗАДАЧА 1: Угадай число
// Что учим: циклы, условия, TryParse
// ============================================================
// Программа загадывает число от 1 до 10.
// Пользователь вводит число с клавиатуры.
// Нужно проверить что введено число и оно от 1 до 10.
// Игра продолжается пока пользователь не угадает.
// если угадал — поздравь и напиши что выйграли.
// если меньше — подскажи "Загаданное число больше"
// если больше — подскажи "Загаданное число меньше"

// так можно взять случайное число
var randomNumber = Random.Shared.Next(1, 11);

Console.WriteLine("Введите число от 1 до 10");

bool isCompleted = false;
while (isCompleted == false)
{
    var userInput = Console.ReadLine();
    bool isValidNumber = int.TryParse(userInput, out int userNumber);
    if (isValidNumber == false || userNumber < 1 || userNumber > 10)
    {
        Console.WriteLine("Неверный ввод. Попробуйте еще раз");
        continue;
    }

    if (userNumber == randomNumber)
    {
        Console.WriteLine("Вы выиграли!");
        isCompleted = true;
    }
    else if (userNumber > randomNumber)
    {
        Console.WriteLine("Загаданное число меньше");
    }
    else
    {
        Console.WriteLine("Загаданное число больше");
    }
}

/*Console.WriteLine("Задача 1.");

var number = Console.ReadLine();
bool conv = int.TryParse(number, out int zahl);
bool isCompleted = false;
while (isCompleted == false)
{
    while (conv == false || !(zahl >= 1 & zahl <= 10))
    {
        Console.WriteLine("Неверный ввод. Попробуйте еще раз");
        number = Console.ReadLine();
        conv = int.TryParse(number, out zahl);
    }
    
    if (conv == true & randomNumber == zahl)
    {
        Console.WriteLine("Вы выиграли");
        isCompleted = true;
    }
    else if (conv == true & randomNumber < zahl)
    {
        Console.WriteLine("Загаданное число меньше");
    }
    else
    {
        Console.WriteLine("Загаданное число больше");
    }

    conv = false;
}*/
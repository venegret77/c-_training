// ============================================================
// ЗАДАЧА 6: Угадай число
// Что учим: циклы, условия, TryParse
// ============================================================
// Программа загадывает число от 1 до 10.
// Пользователь вводит число с клавиатуры.
// Нужно проверить что введено число и оно от 1 до 10.
// Игра продолжается пока пользователь не угадает.
// если угадал — поздравь и напиши что выйграли.
// если меньше — подскажи "Загаданное число больше"
// если больше — подскажи "Загаданное число меньше"

// ВАЖНОЕ ОТЛИЧИЕ, НУЖНО СОЗДАТЬ МЕТОД ОТДАЮЩИЙ ВАЛИДНОЕ ЧИСЛО КОТОРОЕ ДОЛЖЕН ВВЕСТИ ПОЛЬЗОВАТЕЛЬ
// СДЕЛАТЬ ЧЕРЕЗ while(true)
// int GetValidUserNumber(){}

// так можно взять случайное число

var computerNumber = Random.Shared.Next(1, 11);

Console.WriteLine("Введите число от 1 до 10"); // Выводит пользователю сообщение

int Number()
{
    while (true)
    {
        var userInput = Console.ReadLine();
        bool isValidNumber = int.TryParse(userInput, out int userNumber);
        if (isValidNumber == false || userNumber < 1 || userNumber > 10)
        {
            Console.WriteLine("Неверный ввод. Попробуйте еще раз");
        }
        else
        {
            return userNumber;
        } 
    }
}
while (true)
{
    int userNumber = Number();
    if (userNumber == computerNumber)
    {
        Console.WriteLine("Вы выиграли!");
        break;
    }
    else if (userNumber > computerNumber)
    {
        Console.WriteLine("Загаданное число меньше");
    }
    else
    {
        Console.WriteLine("Загаданное число больше");
    }
}


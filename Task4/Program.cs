// ============================================================
// ЗАДАЧА 4: Угадай день недели
// Что учим: switch, if/else, TryParse, условия
// ============================================================
// Пользователь вводит число от 1 до 7.
// switch выводит название дня недели.
// if/else дополнительно говорит: рабочий день или выходной.
// Если введено не от 1 до 7 — ошибка.

Console.WriteLine("Задача 4.");
Console.WriteLine("Введите номер дня недели");
var number = Console.ReadLine();
bool numberweek = int.TryParse(number, out int zahlweek);
while (numberweek == false)
{
    Console.WriteLine("Неверный ввод");
    Console.WriteLine("Повторно введите число");
    number = Console.ReadLine();
    numberweek = int.TryParse(number, out zahlweek);
}

    switch (zahlweek)
    {
        case 1:
            Console.WriteLine("Montag");
            break;
        case 2:
            Console.WriteLine("Dienstag");
            break;
        case 3: 
            Console.WriteLine("Mittwoch");
            break;
        case 4: 
            Console.WriteLine("Donnerstag");
            break;
        case 5:
            Console.WriteLine("Freitag");
            break;
        case 6:
            Console.WriteLine("Samstag");
            break;
        case 7:
            Console.WriteLine("Sonntag");
            break;
        default:
            Console.WriteLine("Неверный ввод");
            break;
    }

    if (zahlweek == 6 || zahlweek == 7)
    {
        Console.WriteLine("Выходной");
    }
    else
    {
        Console.WriteLine("Рабочий день");
    }


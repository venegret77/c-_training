// ============================================================
// ЗАДАЧА 5: Банкомат
// Что учим: switch, циклы, TryParse, логические операторы (&&)
// ============================================================
// Начальный баланс 1000 рублей.
// Показывай меню в цикле:
//   1. Пополнить
//   2. Снять
//   3. Проверить баланс
//   4. Выйти
// При пополнении: сумма должна быть > 0
// При снятии: сумма должна быть > 0 && сумма <= баланса
// Цикл крутится пока не выбрали "Выйти"

Console.WriteLine("Задача 5.");

int balance = 1000;
while (true)
{
    Console.WriteLine("Выберите пункт меню\n 1.Пополнить\n 2.Снять\n 3.Проверить баланс\n 4.Выйти");
    
    var input = Console.ReadLine();
    var isValid = int.TryParse(input, out var inputInt);

    if (isValid == true && inputInt == 1) 
    {
        Console.WriteLine("Введите сумму депозита");
        var deposit = Console.ReadLine();
        bool isValidDeposit = int.TryParse(deposit, out var depositInt);

        if (isValidDeposit == true && depositInt > 0)
        {
            balance = balance + depositInt;
            Console.WriteLine($"Депозит успешен. Ваш баланс {balance}");
        }
        else
        {
            Console.WriteLine("Неверный ввод");
        }
    }

    if (isValid == true && inputInt == 2)
    {
        Console.WriteLine("Введите сумму вывода");
        var withdraw = Console.ReadLine();
        bool isValidWithdraw = int.TryParse(withdraw, out var withdrawInt);
        
        if (isValidWithdraw == true && (withdrawInt > 0 && withdrawInt <= balance))
        {
            balance = balance - withdrawInt;
            Console.WriteLine($"Вывод успешен. Остаток на счете {balance}");
        }
        else
        {
            Console.WriteLine("Неверный ввод");
        }
    }

    if (isValid == true && inputInt == 3)
    {
        Console.WriteLine($"Сумма на счете: {balance}");
    }

    if (isValid == true && inputInt == 4)
    {
        break;
    }
}



    
    
    
/*Console.WriteLine("Неверный ввод. Выберите предложенный пункт меню");
var userinput = int.TryParse(input, out uinnput);

if (uinnput == 1)
{
    Console.WriteLine("Внесите сумму депозита");
    var inputdep = Console.ReadLine();
    bool firstdep = int.TryParse(inputdep, out var finishdep);
    if (firstdep == true & finishdep > 0)
    {
        deposumm = finishdep + balance;
        Console.WriteLine($"Успешный депозит. Сумма на счете: {deposumm}");
        exit = true;
    }
    else
    {
        Console.WriteLine("Неверная сумма депозита");
    }
}*/






/*switch (erstesumm)
{
    case 1:
        Console.WriteLine("Пополнить");
        break;
    case 2:
        Console.WriteLine("Снять");
        break;
    case 3:
        Console.WriteLine("Проверить баланс");
        break;
    default:
        Console.WriteLine("Выход");
        break;
}*/
/*Задача 1. Калькулятор-вечный двигатель
    Сделай простой консольный калькулятор на while(true). На каждой итерации:

Спроси первое число.
    Спроси оператор (+, -, *, /) — можно просто как строку.
    Спроси второе число.
    Через if/else if (или switch) посчитай результат и выведи его.
    После вывода спроси: "Хотите продолжить? (да/нет)". Если "нет" — break, если "да" — цикл начинается заново.*/
    
while (true)
{
    Console.WriteLine("Введите первое число");
    var numberOne = Console.ReadLine();
    bool numberOneResult = double.TryParse(numberOne, out double numberOneDouble);
    while (numberOneResult == false)
    {
        Console.WriteLine("Ввод неверный");
        numberOne = Console.ReadLine();
        numberOneResult = double.TryParse(numberOne, out numberOneDouble);
    }
    
    Console.WriteLine("Введите символ операции");
    var symbol = Console.ReadLine();
    while (!(symbol == "+" || symbol == "-" || symbol == "*" || symbol == "/"))
    {
        Console.WriteLine("Ввод неверный");
        symbol = Console.ReadLine();
    }

    Console.WriteLine("Введите второе число");
    var numbertwo = Console.ReadLine();
    bool numberTwoResult = double.TryParse(numbertwo, out double numberTwoDouble);
    while (numberTwoResult == false)
    {
        Console.WriteLine("Ввод неверный");
        numbertwo = Console.ReadLine();
        numberTwoResult = double.TryParse(numbertwo, out numberTwoDouble);
    }
    if (symbol == "+")
    {
       double resultitog = numberTwoDouble + numberOneDouble;
       Console.WriteLine($"Итого {resultitog}");
    }
    else if (symbol == "-")
    {
        double resultitog = numberTwoDouble - numberOneDouble;
        Console.WriteLine($"Итого {resultitog}");
    }
    else if (symbol == "*")
    {
        double resultitog = numberTwoDouble * numberOneDouble;
        Console.WriteLine($"Итого {resultitog}");
    }
    else
    {
        double resultitog = numberTwoDouble / numberOneDouble;
        Console.WriteLine($"Итого {resultitog}");
    }
    Console.WriteLine("Хотите продолжить?\n Yes\n No\n");
    var Choose = Console.ReadLine();
    if (Choose == "Yes")
    {
        continue;
    }
    else if  (Choose == "No")
    {
        break;
    }
    else
    {
        Console.WriteLine("Неверный ввод. Выход неуспешен");
    }
}
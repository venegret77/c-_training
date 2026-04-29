namespace C.Training;

public static class BasicTasks
{
    // ЗАДАЧА 1:
    // Вернуть строку: "Привет, я учу C#!"
    // Никаких параметров нет, просто вернуть нужный текст.
    public static string SayHello()
    {
        return "Привет, я учу C#!";
    }

    // ЗАДАЧА 2:
    // На вход подаются name и age.
    // Нужно вернуть строку в формате:
    // "Меня зовут {name}, мне {age}"
    // Используй интерполяцию строк ($"...").
    public static string FormatPerson(string name, int age)
    {
        return $"Меня зовут {name}, мне {age}";
    }

    // ЗАДАЧА 3:
    // Вернуть сумму двух чисел a и b.
    // Ничего сложнее, чем a + b, тут не требуется.
    public static int Sum(int a, int b)
    {
        return a + b;
    }

    // ЗАДАЧА 4:
    // Вернуть квадрат числа number.
    // Пример: 4 -> 16
    public static int Square(int number)
    {
        return number * number;
    }

    // ЗАДАЧА 5:
    // Проверить, является ли число чётным.
    // Вернуть true, если чётное, иначе false.
    // Подсказка: используй оператор %
    public static bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    // ЗАДАЧА 6:
    // Вернуть сумму чисел от 1 до n.
    // Пример: n = 5 → 1+2+3+4+5 = 15
    // Можно использовать цикл (for/while).
    // Если n = 0, вернуть 0.
    public static int SumToN(int n)
    {
        var sum = 0;
        for (var i = 0; i <= n; i++)
        {
            sum += i;
        }

        return sum;
    }
}
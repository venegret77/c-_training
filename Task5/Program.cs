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

/*int balance = 1000;
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
}*/



    
    
    
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



/*var Developer = new Developer();

var Tester = new Tester();

List<IEmployee> test = new List<IEmployee>();
test.Add(Developer);
test.Add(Tester);
foreach (var result in test)
{
    result.DoWork();
}

public interface IEmployee
{
    public void DoWork();
}

public class Developer: IEmployee
{
    public void DoWork()
    {
        Console.WriteLine("Хер");
    }
}

public class Tester: IEmployee
{
    public void DoWork()
    {
        Console.WriteLine("Пизда");
    }
}*/


/*var Guitar = new Guitar();
var Piano = new Piano();
List<BaseInstrument> instruments = new List<BaseInstrument>();
instruments.Add(Guitar);
instruments.Add(Piano);
foreach (var result in instruments)
{
    result.Play();
}


public abstract class BaseInstrument
{
    public abstract void Play();
}

public class Guitar : BaseInstrument
{
    public override void Play()
    {
        throw new NotImplementedException();
    }
}
public class Piano : BaseInstrument
{
    public override void Play()
    {
        Console.WriteLine("Для нормальных людей");
    }
}*/



/*var book1 = new Book ("Harry Potter - ebeni kurac", 1);
var book2 = new Book ("Harry Potter - ebeni kurac", 1);
Console.WriteLine(book1 == book2);
var newBook = book2 with {Pages = 3};
Console.WriteLine($"{book1.Title}, {book1.Pages}");
Console.WriteLine($"{book2.Title}, {book2.Pages}");
Console.WriteLine($"{newBook.Title}, {newBook.Pages}");
Console.WriteLine(newBook == book1);
public record Book (string Title, int Pages);*/



/*void DescribeSeason(Season result)
{
    switch (result)
    {
        case Season.Winter:
            Console.WriteLine("Winter");
            break;
        case Season.Spring:
            Console.WriteLine("Spring");
            break;
        case Season.Summer:
            Console.WriteLine("Summer");
            break;
        case Season.Autumn:
            Console.WriteLine("Autumn");
            break;
    }
}

DescribeSeason(Season.Winter);
DescribeSeason(Season.Spring);
DescribeSeason(Season.Autumn);
DescribeSeason(Season.Summer);

public enum Season
{
    Winter,
    Spring,
    Summer,
    Autumn
}*/



/*public static class StrtingH
{
    public static string Reverse(this string str)
    {
       Console.WriteLine($"Введенная строка {str}");
       Console.WriteLine(str.Length);
       var result = str.Length;
       string newString = string.Empty;
       for (var i = result; i > 0; i--)
       {
           newString = newString + str[i];
       }

       return newString;
    }
}*/

/*T GetFirst<T>(T[] array)
{
    return array[0];
}

int[] arraynew = new int[3] {1,2,3};
string[] arraynewnew = new string[2] {"one", "two"};
string first = GetFirst<string>(arraynewnew);
int two = GetFirst<int>(arraynew);*/

/*T GetLast<T>(T[] array)
{
    int zahl = array.Length - 1;
    return array[zahl];
}
int[] arrayfirst = new int[] {1,2,3,4,5};
string[] arraytwo = new string[] { "one", "two", "three" };
int first = GetLast(arrayfirst);
string two = GetLast(arraytwo);*/

/*void PrintTwice<T>(T value)
{
    Console.WriteLine(value);
    Console.WriteLine(value);
}

PrintTwice("Memento mori");
PrintTwice(1);
for (int a = 0; a < 2; a++)
{
    PrintTwice("Memento mori");
    PrintTwice(1);
}*/

/*delegate int Result (int a, int b);
int Multiply(int a, int b)
{
    return a * b;
}
Result itog = Multiply;
int itogResult = itog(4,5);
Console.WriteLine(itogResult);*/

/*int Multiply(int a, int b)
{
    return a * b;
}
Func<int, int, int> result = Multiply;
int itogresult = result(4,5);
Console.WriteLine(itogresult);*/

/*Action<string> print = Console.WriteLine;
print("Тест пройден");*/

/*int Square(int n)
{
    return n * n;
}

Func<int, int> add = n => n * n;*/

/*Func<string, bool> result = x => x.Length >5;*/

/*Func<int, int, int> result =(a,b)=>  a > b ? a : b;*/
Func<int,int,int> result = (a,b)=>
if (a > b)
{
    Conso
}
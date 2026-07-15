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

/*int chislo = 0;
while (true)
{
    Console.WriteLine("Введите число от 1 до 4");
    var first = Console.ReadLine();
    bool two = int.TryParse(first, out chislo);
    if (two == true && (chislo > 0 && chislo < 5))
    {
        break;
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Неверный ввод");
    }
}

Console.WriteLine($" Это {chislo}");*/


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















/*public class TestCase
{
    public string Name;
    public bool Passed;

    public TestCase (string name, bool passed)
    {
        Name = name;
        Passed = passed;
    }
}
TestCase test1 = new TestCase("TC1", true);
TestCase test2 = new TestCase("TC2", true);
TestCase test3 = new TestCase("TC3", false);
List<TestCase> TestCases = new List<TestCase>();
TestCases.Add(test1);
TestCases.Add(test2);
TestCases.Add(test3);
var NewFalse = TestCases
    .Where(x => x.Passed == false)
    .Select(x => x.Name)
    .ToList();
foreach (var Result2 in NewFalse)
{
   Console.WriteLine(Result2); 
}*/
/*public class TestCase
{
    public string Name { get; set; }
    public bool Passed { get; set; }
    public int Speed { get; set; }

    public TestCase(string name, bool passed, int speed)
    {
        Name = name;
        Passed = passed;
        Speed = speed;
    }
}

TestCase test1 = new TestCase("Create", true, 200);
TestCase test2 = new TestCase("Upgrade", true, 350);
TestCase test3 = new TestCase("Search", false, 1000);
List<TestCase> TestCases = new List<TestCase>();
TestCases.Add(test1);
TestCases.Add(test2);
TestCases.Add(test3);
var result = TestCases.FirstOrDefault(x => x.Name == "Search");
if (result != null)
{
    Console.WriteLine(result.Name);
}
else
{
    Console.WriteLine("Такого кейса нет");
}*/


/*public class TestCase
{
    public string Name { get; set; }
    public bool Passed { get; set; }
    public int Speed { get; set; }

    public TestCase(string name, bool passed, int speed)
    {
        Name = name;
        Passed = passed;
        Speed = speed;
    }
}

TestCase test1 = new TestCase("Create", true, 200);
TestCase test2 = new TestCase("Upgrade", true, 350);
TestCase test3 = new TestCase("Search", false, 1000);
List<TestCase> TestCases = new List<TestCase>();
TestCases.Add(test1);
TestCases.Add(test2);
TestCases.Add(test3);
bool result = TestCases.Any(x => x.Speed == 1000);
if (result == true)
{
    Console.WriteLine("Такой тест есть");
}
else
{
    Console.WriteLine("Tакого теста нет");
}*/

/*public class BaseAnimal
{
    public string Name { get; set; }
    public int Age { get; set; }
    public void MakeSound()
    {
        Console.WriteLine("Издает звук");
    }
}

public class Animal : BaseAnimal
{
    public void Fetch()
    {
        Console.WriteLine("Приносит палку");
    }
}

Animal dog = new Animal()
{
    Name = "Dog",
    Age = 2
};

dog.MakeSound();
dog.Fetch();*/


/*public class BasePage
{
    public string Url { get; set; }

    public void Open()
    {
        Console.WriteLine($"Открываем страницу {Url}");
    }

    public void WaitForLoad()
    {
        Console.WriteLine("Ждем загрузки страницы...");
    }
}

public class ProfilePage: BasePage
{
    public ProfilePage()
    {
        Url = "https://site.com/profile";
    }
    public void ChangeAvatar()
  {
     Console.WriteLine("Аватар изменен"); 
  }
}

var Page = new ProfilePage();
Page.Open();
Page.WaitForLoad();
Page.ChangeAvatar();*/


/*public interface IPet
{
    void Play();
}

public class Dog : IPet
{
    public void Play()
    {
        Console.WriteLine("Собака гоняется за мячом");
    }
}

public class Parrot : IPet
{
    public void Play()
    {
        Console.WriteLine("Попугай летает по комнате");
    }
}*/

public abstract class BaseDog
{
    public string Name { get; set; }

    public abstract void MakeSound();
}

public class Labrador : BaseDog
{
    public override void MakeSound()
    {
        Console.WriteLine("Резат хохлов!");
    }
}

public class Siba : BaseDog
{
    public override void MakeSound()
    {
        Console.WriteLine("Омайва машиндеру!");
    }
}

var koni = new Labrador()
{
    Name = "Koni"
};
koni.MakeSound();
var jebanashka = new Siba()
{
    Name = "Jebanashka"
};
jebanashka.MakeSound();













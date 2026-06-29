/*Создай класс Person (человек) с тремя полями:

Name (имя, string)
Age (возраст, int)
City (город, string)

Сделай конструктор который заполняет все три поля. Потом создай объект и выведи его данные*/

using Task6;

class Person
{
    public string Name;
    public int Age;
    public string City;

    public Person(string name, int age, string city)
    {
        Name = name;
        Age = age;
        City = city;
    }
}
Person germanperson = new Person ("Wilhelm", 83, "Quedlinburg");
Console.WriteLine(germanperson.Name);
Console.WriteLine(germanperson.Age);
Console.WriteLine (germanperson.City); 

/*Создай класс Book с полями:

Title (название, string)
Author (автор, string)
Year (год, int)

Конструктор заполняет все поля. Создай объект книги и выведи данные.*/

class Book
{
    public string Title;
    public string Autor;
    public int Year;

    public Book(string title, string autor, int year)
    {
        Title = title;
        Autor = autor;
        Year = year;
    }
}
Book buch = new Book ("Faust", "Goete", 1783);
Console.WriteLine(buch.Title);
Console.WriteLine(buch.Autor);
Console.WriteLine(buch.Year);

/*Создай класс Product с полями:

Name (название, string)
Price (цена, decimal)
Quantity (количество, int)

Конструктор заполняет поля. Создай два разных продукта и выведи их данные.*/

Product dildo = new Product ("Dildo Harry Potter", 134.2m, 4);
Console.WriteLine(dildo.Name);
Console.WriteLine(dildo.Price);
Console.WriteLine(dildo.Quantity);
Product rukkola = new Product ("Rukkola Hujukkola", 1.45m, 10);
Console.WriteLine(rukkola.Name);
Console.WriteLine(rukkola.Price);
Console.WriteLine(rukkola.Quantity);
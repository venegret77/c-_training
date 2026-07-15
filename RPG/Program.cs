/*• Массив из 3–4 героев, созданных заранее.
• Цикл меню, работающий пока пользователь не выберет «Выход».
• switch по пункту меню:
1. Показать весь отряд
2. Нанести урон герою (спросить номер героя и сколько урона)
3. Полечить героя
4. Выход
• Ввод числа оборачиваем в try/catch — если пользователь ввёл буквы вместо числа, программа не должна падать, а должна вежливо попросить снова.
• Условия: проверять, что номер героя в пределах массива; помечать [мёртв], если HP = 0.

    Пример работы
           === ОТРЯД ===
    1. Показать отряд
2. Атаковать
3. Лечить
4. Выход
Выбор: 1

Арагорн: 100/100 HP [жив]
Гэндальф: 80/80 HP [жив]
Леголас: 90/90 HP [жив]

Выбор: 2
Кого атакуем (номер)? 1
Урон? ой
Нужно число, попробуй снова.
    Урон? 60
Арагорн получает 60 урона. Осталось 40 HP.


    Что тренируем
Карта тем (для самопроверки)

Циклы — меню и вывод отряда · Массивы — сам отряд · Методы — TakeDamage + GetStatus · Классы — Hero + Program · Условия — проверка HP и границ массива · Switch — меню · private/public — HP закрыто, методы открыты · try/catch — парсинг ввода.

    Бонус (если пойдёт легко)

Добавить в лечение правило: нельзя вылечить выше максимума, и нельзя лечить мёртвого героя — «его уже не спасти».*/


using System.Security.Principal;
using RPG;

Random random = new Random();
double wound = random.Next(1, 11);
double heal = random.Next(1, 11);
int person = random.Next(0, 4);
Hero [] heroes = new Hero [4];
heroes [0] = new Hero ("Warrior", "Minsk", 200, 20);
heroes [1] = new Hero ("Thief", "Artemis", 150,15);
heroes [2] = new Hero ("Priest", "Kedderly", 100, 10);
heroes [3] = new Hero ("Wizard", "Elminster", 50, 5);
while (true)
{
  Console.WriteLine("Меню Отряд");
  Console.WriteLine("1.Показать весь отряд \n2.Нанести урон герою \n3.Лечить героя \n4. Выход");
  Console.WriteLine("Выберите пункт меню");
  var paragraph = Console.ReadLine();
  int result = 0;
  try
  { 
      result = Convert.ToInt32(paragraph);
  }
  catch
  {
      Console.WriteLine("Ввод неверный. Повторите ввод");
      continue;
  }
  switch (result)
  {
  case 1:
      Console.WriteLine("Показать весь отряд");
      foreach (var hero in heroes)
      {
          bool live = hero.IsAlive();
          var status = live ? "Жив" : "Мертв";
          Console.WriteLine($"Класс:{hero.Role}, Имя:{hero.Name}, Hp: {hero.Hp}, Урон:{hero.Damage}, Статус: {status}"); 
          }
      break;
  case 2:
      Console.WriteLine("Нанести урон герою");
      double Healthpoint(double wound, Hero hero)
      {
          if (hero.Hp >= wound)
          {
              return hero.Hp - wound;
          }
          else
          {
              Console.WriteLine($"Герой {hero.Name} мертв!");
              return 0;
          }
      }
      var randomHero = heroes[person];
      double remainderHp = Healthpoint(wound, randomHero);
      randomHero.Hp = remainderHp;
      Console.WriteLine($"Персонаж {randomHero.Name} получает урон {wound}! Его HP = {remainderHp}");
      break;
  case 3:
      Console.WriteLine("Лечить героя");
      double Heilpoint(double heal, Hero hero)
      {
          return hero.Hp + heal;
      }
      var randomHero2 = heroes[person];
      double healHp = Heilpoint(heal, randomHero2);
      randomHero2.Hp = healHp;
      Console.WriteLine($"Персонаж {randomHero2.Name} исцеляется на {heal}! Его Hp = {healHp}");
      break;
  case 4:
      Console.WriteLine("Выход");
      break;
  }  
}

// ============================================================
// ЗАДАЧА 10: Банкомат — переписываем через класс
// Что учим: классы, конструктор, свойства (get, private set), методы
// Связь с задачей 5
// ============================================================
// Создай класс BankAccount.
// Свойство Balance — только get снаружи (менять только через методы).
// Конструктор принимает начальный баланс.
// Методы Deposit и Withdraw с проверками.
// Метод PrintBalance выводит текущий баланс.
// Перепиши меню из задачи 5, используя объект класса.
 
// TODO: class BankAccount
// {
//     public decimal Balance { get; private set; }
//
//     TODO: конструктор BankAccount(decimal initialBalance)
//     проверь что initialBalance >= 0, иначе выбрось ArgumentException
//
//     TODO: void Deposit(decimal amount)
//     проверь amount > 0
//     Balance += amount
//
//     TODO: void Withdraw(decimal amount)
//     проверь amount > 0 && amount <= Balance
//     Balance -= amount
//
//     TODO: void PrintBalance()
//     вывести "Баланс: {Balance} руб."
// }
 
// TODO: создай объект: var account = new BankAccount(1000);
// TODO: перепиши цикл меню из задачи 5, вызывая методы account

Console.WriteLine("Задача 10.");
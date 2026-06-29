/*Задание
    Создай класс BankAccount (банковский счёт):
Поле/свойство:

Balance (баланс, decimal) — свойство с проверкой: не может быть отрицательным

Конструктор:

принимает начальный баланс

Методы:

Deposit(decimal amount) — пополнить счёт (добавить к балансу)
Withdraw(decimal amount) — снять со счёта (вычесть из баланса)*/

class BankAccount
{
    public decimal Balance { get; private set; }

    public BankAccount(decimal balance)
    {
        Balance = balance;
    }

    public void Deposit(decimal amount)
    {
        Balance = Balance + amount;
    }

    public void Withdraw(decimal amount)
    {
        Balance = Balance - amount;
    }
}
BankAccount account = new BankAccount (100m);
account.Deposit(10m);
account.Withdraw(10m);
Console.WriteLine(account.Balance);


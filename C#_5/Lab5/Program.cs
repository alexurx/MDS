using System;

// Класс для хранения цен
public class Prices
{
    public int Drink = 10;
    public int First = 20;
    public int Second = 30;
}

// Класс для хранения выбора клиента (количество каждого товара)
public class Choices
{
    public int Drink;
    public int First;
    public int Second;

    public Choices(int drink, int first, int second)
    {
        Drink = drink;
        First = first;
        Second = second;
    }
}

class Program
{
    static void Main()
    {
        Prices prices = new Prices();

        // Клиент 1
        {
            Choices client1 = new Choices(drink: 100, first: 0, second: 250);
            int total1 = CustomerTotal(prices, client1);
            Console.WriteLine("Сумма заказа клиента 1: " + total1);
        }

        // Клиент 2
        {
            Choices client2 = new Choices(drink: 0, first: 300, second: 0);
            int total2 = CustomerTotal(prices, client2);
            Console.WriteLine("Сумма заказа клиента 2: " + total2);
        }
    }

    // Функция для подсчета стоимости заказа клиента
    static int CustomerTotal(Prices prices, Choices choices)
    {
        return choices.Drink * prices.Drink +
               choices.First * prices.First +
               choices.Second * prices.Second;
    }
}

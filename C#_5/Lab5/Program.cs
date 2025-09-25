using System;

// 3. Структура для хранения цен
public struct Prices
{
    public int Drink;
    public int First;
    public int Second;

    public Prices(int drink, int first, int second)
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
        // Создаем общий объект с ценами
        Prices prices = new Prices(10, 20, 30);

        // 2. Блок для клиента 1
        {
            int choice1 = 0; // напиток
            int choice2 = 1; // первое
            int total = CalculateOrder(prices, choice1, choice2);
            Console.WriteLine("Сумма заказа клиента 1: " + total);
        }

        // 2. Блок для клиента 2
        {
            int choice1 = 1; // первое
            int choice2 = 2; // второе
            int total = CalculateOrder(prices, choice1, choice2);
            Console.WriteLine("Сумма заказа клиента 2: " + total);
        }
    }

    // 4. Функция для расчета заказа клиента
    static int CalculateOrder(Prices prices, int choice1, int choice2)
    {
        // 5. Используем отдельную функцию для извлечения цены
        return GetPrice(prices, choice1) + GetPrice(prices, choice2);
    }

    // 5. Функция для получения цены по коду товара
    static int GetPrice(Prices prices, int choice)
    {
        return choice switch
        {
            0 => prices.Drink,
            1 => prices.First,
            2 => prices.Second,
            _ => 0
        };
    }
}

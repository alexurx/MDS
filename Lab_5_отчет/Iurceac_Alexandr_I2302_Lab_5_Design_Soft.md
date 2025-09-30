## Тема

Элементарные техники программирования: работа с функциями, блоками и пользовательскими типами.

---

## Цели

* Освоить группировку логически связанных данных в классах/структурах.
* Научиться ограничивать видимость переменных через блоки `{ }`.
* Создавать функции для удаления повторяющегося кода.
* Понимать механизм вызова функций для обработки различных клиентов.

---

## Ход работы

### 1. Создание класса для цен

```csharp
public class Prices
{
    public int Drink = 10;
    public int First = 20;
    public int Second = 30;
}
```

* Класс Prices хранит цены всех товаров, чтобы не использовать «магические числа» напрямую.

---

### 2. Создание класса выбора клиента

```csharp
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
```

* Класс Choices хранит количество каждого товара для конкретного клиента.

---

### 3. Основная программа

```csharp
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
```

* Каждый клиент представлен отдельным блоком `{ }`.
* Переменные с одинаковыми именами (`client1`, `client2`) не конфликтуют.

---

### 4. Функция расчёта стоимости заказа

```csharp
static int CustomerTotal(Prices prices, Choices choices)
{
    return choices.Drink * prices.Drink +
           choices.First * prices.First +
           choices.Second * prices.Second;
}
```

* Убирает повторение кода для каждого клиента.
* Принимает параметры: цены и выбор клиента.
* Возвращает общую стоимость заказа.

---

## Вывод

* Освоено использование **классов** для группировки данных.
* Понято, как ограничивать видимость переменных через **блоки `{ }`**.
* Повторяющийся код вынесен в функцию `CustomerTotal`, что повышает читаемость и повторное использование.
* Научились вызывать функции с параметрами для обработки различных клиентов.
* Программа корректно считает стоимость заказов для каждого клиента.
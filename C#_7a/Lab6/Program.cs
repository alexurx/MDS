using System;
using System.Diagnostics;

class Program
{
    // Функция, реализующая алгоритм попарной суммы
    static void PairwiseSum(int[] list1, int[] list2, int[] result)
    {
        // Проверка корректности размеров массивов
        if (list1.Length != list2.Length || list1.Length != result.Length)
        {
            throw new ArgumentException("Все массивы должны иметь одинаковую длину.");
        }

        // Основной алгоритм: попарная сумма
        for (int i = 0; i < list1.Length; i++)
        {
            result[i] = list1[i] + list2[i];
        }
    }

    static void Main()
    {
        // Исходные данные
        int[] list1 = { 2, 4, 6, 8 };
        int[] list2 = { 1, 3, 5, 7 };

        // Массив для результата
        int[] result = new int[list1.Length];

        // Вызов функции
        PairwiseSum(list1, list2, result);

        // Вывод результата
        Console.WriteLine("Результат попарной суммы:");
        foreach (int value in result)
        {
            Console.WriteLine(value);
        }
    }
}
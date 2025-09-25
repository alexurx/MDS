using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Два исходных списка
        List<int> list1 = new List<int> { 1, 2, 3, 4 };
        List<int> list2 = new List<int> { 10, 20, 30, 40 };

        // Вызов функции для вычисления попарной суммы
        List<int> sumList = PairwiseSum(list1, list2);

        // Вывод результата
        Console.WriteLine("Попарная сумма элементов:");
        foreach (var sum in sumList)
        {
            Console.WriteLine(sum);
        }
    }

    // Функция, вычисляющая попарную сумму
    static List<int> PairwiseSum(List<int> list1, List<int> list2)
    {
        List<int> result = new List<int>();

        for (int i = 0; i < list1.Count; i++)
        {
            // Вызов "подалгоритма" для суммы двух чисел
            result.Add(SumTwoNumbers(list1[i], list2[i]));
        }

        return result;
    }

    // Подалгоритм: сумма двух чисел
    static int SumTwoNumbers(int a, int b)
    {
        return a + b;
    }
}

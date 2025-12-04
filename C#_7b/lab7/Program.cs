using System;

class ProgramWhile
{
    static void PairwiseSumWhile(int[] list1, int[] list2, int[] result)
    {
        if (list1.Length != list2.Length || list1.Length != result.Length)
            throw new ArgumentException("Все массивы должны иметь одинаковую длину.");

        int i = 0;
        while (i < list1.Length)
        {
            result[i] = list1[i] + list2[i];
            i++;
        }
    }

    static void Main()
    {
        int[] list1 = { 10, 20, 30 };
        int[] list2 = { 5, 15, 25 };
        int[] result = new int[list1.Length];

        PairwiseSumWhile(list1, list2, result);

        Console.WriteLine("Результат попарной суммы (while):");
        foreach (int value in result)
        {
            Console.WriteLine(value);
        }
    }
}
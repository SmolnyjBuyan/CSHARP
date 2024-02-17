﻿int[] SumRows(int[,] array)
{
    int[] sumElementsOfRows = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sumElementsOfRow = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumElementsOfRow = sumElementsOfRow + array[i, j];
        }
        sumElementsOfRows[i] = sumElementsOfRow;
        sumElementsOfRow = 0;
    }
    return sumElementsOfRows;
}

int MinIndex(int[] array)
{
    int minIndex = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < array[minIndex]) minIndex = i;
    }
    return minIndex;
}

int[,] numbers = new int[,] {
    {1, 2, 3},
    {1, 1, 0},
    {7, 8, 2},
    {9, 10, 11}
};

foreach (int e in SumRows(numbers))
{
    Console.Write($"{e} ");
}
Console.WriteLine();

Console.WriteLine(MinIndex(SumRows(numbers)));

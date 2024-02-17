int[,] SwapRows(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int temp = array[0, j];
        array[0, j] = array[array.GetLength(0) - 1, j];
        array[array.GetLength(0) - 1, j] = temp;
    }
    return array;
}



int[,] numbers = new int[,] {
    {1, 2, 3, 4, 5},
    {5, 6, 7, 8, 8},
    {9, 10, 11, 12, 9},
    {13, 14, 15, 16, 17}
};

int[,] result = SwapRows(numbers);

for (int i = 0; i < result.GetLength(0); i++)
{
    for (int j = 0; j < result.GetLength(1); j++)
    {
        Console.Write(result[i, j] + "\t");
    }
    Console.WriteLine();
}

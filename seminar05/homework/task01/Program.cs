char[,] CreateMatrix(int rows, int columns)
{
    char[,] matrix = new char[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = (char)rnd.Next(0x0410, 0x44F);
        }
    }
    return matrix;
}

void PrintMatrix(char[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

string CreateStringFromMatrix(char[,] matrix)
{
    string text = string.Empty;
    foreach (char symbol in matrix)
    {
        text += symbol;
    }
    return text;
}

char[,] result = CreateMatrix(5, 5);
Console.WriteLine("Двумерный массив символов:");
PrintMatrix(result);
Console.Write("Cтрока из символов этого массива: ");
Console.WriteLine(CreateStringFromMatrix(result));

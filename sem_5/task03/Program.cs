// Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0,0); (1;1) и
// т.д.

int [,] CreateMatrix(int rows, int cols)
{
    int[,] matrix = new int[rows, cols];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = rnd.Next(101);
        } 
    }
    return matrix;
}

void PrintMatrix (int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}\t");
        }
        Console.WriteLine(); 
    }
}

double[] GetArrayWithMeans(int[,] matr)
{
    double[] means = new double[matr.GetLength(0)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        double currentSum = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            currentSum += matr[i, j];
        }
        double currentMeans = Math.Round(currentSum / matr.GetLength(1), 2);
        means[i] = currentSum / matr.GetLength(1);
    }
    return means;
}




Console.Write("Введите количество строчек: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] result = CreateMatrix(rows, cols);
PrintMatrix(result);



double[] means = GetArrayWithMeans(result);

Console.WriteLine($"Результат: [{string.Join("; ", means)}]");
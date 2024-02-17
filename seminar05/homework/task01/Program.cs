int GetElement(int[,] array, int row, int column)
{
    int result = array[row - 1, column - 1];
    return result;
}



int[,] numbers = new int[,] {
    {1, 2, 3, 4},
    {5, 6, 7, 8},
    {9, 10, 11, 12}
};



Console.Write("Введите номера ряда: ");
int row = int.Parse(Console.ReadLine()!);
if (row > numbers.GetLength(0) || row <= 0)
{
    Console.WriteLine("Позиция по рядам выходит за пределы массива");
    return;
}

Console.Write("Введите номер колонки: ");
int column = int.Parse(Console.ReadLine()!);
if (column > numbers.GetLength(1) || column <= 0)
{
    Console.WriteLine("Позиция по колонкам выходит за пределы массива");
    return;
}

Console.WriteLine(GetElement(numbers, row, column));

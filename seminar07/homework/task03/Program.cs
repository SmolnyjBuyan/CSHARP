int[] CreateArray(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100);
    }
    return array;
}

void PrintReverseArray(int[] array, int index)
{
    if (index == 0)
    {
        Console.Write(array[index]);
        return;
    }
    Console.Write(array[index] + ", ");
    PrintReverseArray(array, index - 1);
}

int[] example = CreateArray(8);
Console.WriteLine($"Сгенерированный массив: [{String.Join(", ", example)}]");
Console.Write($"Вывод элементов, начиная с конца: ");
PrintReverseArray(example, example.Length - 1);
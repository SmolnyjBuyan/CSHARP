int[] ReverseArray(int[] array)
{
    for (int i = 0, j = array.Length - 1; i < array.Length / 2; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
    return array;
}

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

while (true)
{
    Console.Write("Задайте размер массива:");
    string? input = Console.ReadLine();
    if (int.TryParse(input, out int N) && N > 0)
    {
        int[] someArray = CreateArray(N);
        Console.WriteLine($"Изначальный массив: [ {string.Join("; ", someArray)} ]");
        Console.WriteLine($"Перевернутый массив:[ {string.Join("; ", ReverseArray(someArray))} ]");
        break;
    }
    else
    {
        Console.WriteLine("Введите целое число > 0");
    }
}

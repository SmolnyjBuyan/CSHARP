int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

int ShowCountOfEvenArraysNumbers(int[] array)
{
    int count = 0;
    foreach (int a in array)
    {
        if (a % 2 == 0) count++;
    }
    return count;
}


while (true)
{
    Console.Write("Задайте размер массива:");
    string? input = Console.ReadLine();
    if (int.TryParse(input, out int N))
    {
        int[] someArray = CreateArray(N);
        Console.WriteLine($"[ {string.Join("; ", someArray)} ]");
        Console.WriteLine($"Количество четных чисел в массиве: {ShowCountOfEvenArraysNumbers(someArray)}");
        break;
    }
    else
    {
        Console.WriteLine("Введите целое число > 0");
    }
}
// Задайте массив из N случайных целых чисел (N вводится с
// клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и
// делятся нацело на 7.
// Пример
// [1 5 11 21 81 4 0 91 2 3]
// => 2

int[] CreateArray(int size, int minRange, int maxRange)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minRange, maxRange + 1);
    }
    return array;
}

int CountNumbers(int[] array)
{
    int count = 0;
    foreach (int a in array)
    {
        if (a % 10 == 1 && a % 7 == 0) count++;  
    }
      return count;
}

Console.Write("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
// int size = N, int minRange = 10, int maxRange = 90
int[] res = CreateArray(N, 10, 90);
Console.WriteLine($"Массив: [ {string.Join("; ", res)} ]");
Console.WriteLine($"Количество чисел, которые оканчиваются на 1 и делятся нацело на 7: {CountNumbers(res)}");
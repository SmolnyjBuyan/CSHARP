// Заполните массив на N (вводится с консоли, не более 8)
// случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из
// массива. Старший разряд числа находится на 0-м индексе,
// младший – на последнем.
// Пример
// [1 3 2 4 2 3] => 132423
// [2 3 1] => 231




int[] CreateArray(int N)
{
    int[] array = new int[N];
    for (int i = 0; i < N; i++)
    {
        array[i] = new Random().Next(10);
    }
    return array;
}

int ConvertArrayToInteger(int [] array)
{
    int result = 0;
    for (int i = 0, j = array.Length - 1; i < array.Length; i++ , j--)
    {
        result = result + array[i] * (int)Math.Pow(10, j);
    }
    return result;
}



Console.Write("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N > 8)
{
    Console.WriteLine("Размер > 8 элементов");
    return; // Ломает программу
}

int[] res = CreateArray(N);
Console.WriteLine($"Массив: [ {string.Join("; ", res)} ]");

Console.WriteLine($"Число: {ConvertArrayToInteger(res)}");









// int[] CreateArray(int size)
// {
//     int[] array = new int[size]; // Массив на size элементов
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(10); // [0,9]:0,1,2,3,4,5,6,7,8,9
//     }
//     return array;
// }
// // [2,3,9] => 239
// int ConvertArrayToInteger(int[] array)
// {
//     int result = 0;
//     for (int i = 0, j = array.Length - 1; i < array.Length; i++, j--)
//     {
//         result = result + array[i] * (int)Math.Pow(10, j);
//     }
//     return result;
// }

// Console.Write("Введите размер массива: ");
// int N = Convert.ToInt32(Console.ReadLine());
// // int size = N, int minRange = 10, int maxRange = 90
// int[] res = CreateArray(N); // Массив на N элементов , эл: [0,9]
// Console.WriteLine($"Массив: [ {string.Join("; ", res)} ]");
// if (N > 8)
// {
//     Console.WriteLine("Размер > 8 элементов");
//     return; // Ломает программу, если размер > 8 эл
// }
// Console.WriteLine($"Число: {ConvertArrayToInteger(res)}");
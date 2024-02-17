// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N=5 => 1 2 3 4 5
// start = 1, end = 5

/// <summary>
/// Метод печатает все числа от 1 до N
/// </summary>
/// <param name="start"> точка начала, у нас - 1 </param>
/// <param name="end"> точка остановки, у нас - N </param>
// start = 1, end = 5: 1 2 3 4 5
void ShowNumbers (int start, int end)
{
    // Базовый случай
    if (start == end)
    {
        Console.Write(start);
        return;
    }
    // Рекурсивный случай
    Console.Write(start + " ");
    ShowNumbers(start + 1, end);
}
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
ShowNumbers(1, N); // start = 1, end = N
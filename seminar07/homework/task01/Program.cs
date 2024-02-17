void PrintNumbers(int start, int end, int step)
{
    // Базовый случай
    if (start == end)
    {
        Console.Write(start);
        return;
    }
    // Рекурсивный случай
    Console.Write(start + ",");
    PrintNumbers(start + step, end, step);
}

int GetValue(string name)
{
    while(true)
    {
        Console.Write($"Задайте значение {name}: ");
        if (int.TryParse(Console.ReadLine(), out int result))
        {
            return result;
        }
        Console.WriteLine("Не удалось распознать число, попробуйте еще раз");
    }
}

int GetStep(int start, int end)
{
    if (start < end) return 1;
    else return -1; 
}

int CheckValueForConditions(int input)
{
    if (input <= 0) return 1;
    return input;
}

int M = GetValue("M");
int N = GetValue("N");

if (M <= 0 && N <= 0) Console.WriteLine("В этом отрезке не существует натуральных чисел");
else
{
    Console.WriteLine($"Натуральные числа в промежутке от {M} до {N}: ");
    PrintNumbers(CheckValueForConditions(M), CheckValueForConditions(N), GetStep(M, N));
}

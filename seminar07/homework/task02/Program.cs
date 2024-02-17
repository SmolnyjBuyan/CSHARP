int CountAckermann(int n, int m)
{
    if (n == 0) return m + 1;
    else if (m == 0) return CountAckermann(n - 1, 1);
    else return CountAckermann(n - 1, CountAckermann(n, m - 1));
}

int GetPositiveInteger(string name)
{
    while(true)
    {
        Console.Write($"Задайте значение {name}: ");
        if (int.TryParse(Console.ReadLine(), out int result))
        {
            if (result < 0) Console.WriteLine("Число должно быть неотрицательным");
            else return result;
        }
        else Console.WriteLine("Не удалось распознать число, попробуйте еще раз");
    }
}

int n = GetPositiveInteger("n");
int m = GetPositiveInteger("m");

Console.WriteLine($"A({n},{m}) = {CountAckermann(n, m)}");
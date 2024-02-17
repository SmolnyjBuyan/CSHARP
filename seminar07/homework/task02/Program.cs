int CountAckermann(int n, int m)
{
    if (n == 0) return m + 1;
    else if (m == 0) return CountAckermann(n - 1, 1);
    else return CountAckermann(n - 1, CountAckermann(n, m - 1));
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

Console.WriteLine(CountAckermann(GetValue("n"), GetValue("m")));
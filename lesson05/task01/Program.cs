int Fact(int n)
{
    if (n == 1 || n == 0)
    {
        Console.WriteLine($"Stop: {n}");
        return 1;
    }
    Console.WriteLine(n);
    int temp = n * Fact(n - 1);
    Console.WriteLine($"Возврат:{n}, fact={temp}");
    return temp;
}

Console.WriteLine(Fact(5));
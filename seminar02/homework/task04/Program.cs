int N = 4358976;

if (N >= 1)
{
    int degree = 0;
    int temp = N;

    while (temp >= 10)
    {
        degree++;
        temp = temp / 10;
    }

    while (degree > 0)
    {
        Console.Write($"{N / (int)Math.Pow(10, degree) % 10},");
        degree = degree - 1;
    }
    Console.Write($"{N % 10}");
}
else
{
    Console.WriteLine("Введите натуральное число");
}
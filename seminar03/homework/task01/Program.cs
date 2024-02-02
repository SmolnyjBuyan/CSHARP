int[] numbers = {1, 5, 10, 20, 30, 40, 99, 4, 90, 3};
int count = 0;

foreach (int n in numbers)
{
    if (n >= 10 && n <= 90)
    {
        count++;
    }
}

Console.WriteLine(count);
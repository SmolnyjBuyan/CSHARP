int x = 0;
int y = 0;

if (x == 0 || y == 0)
{
    Console.WriteLine("Условие: X ≠ 0 и Y ≠ 0");
}
else
{
    if (x > 0 && y > 0)
    {
        Console.WriteLine($"{x}, {y} => 1 четверть координатной плоскости");
    }

    if (x < 0 && y > 0)
    {
        Console.WriteLine($"{x}, {y} => 2 четверть координатной плоскости");
    }

    if (x < 0 && y < 0)
    {
        Console.WriteLine($"{x}, {y} => 3 четверть координатной плоскости");
    }

    if (x > 0 && y < 0)
    {
        Console.WriteLine($"{x}, {y} => 4 четверть координатной плоскости");
    }
}

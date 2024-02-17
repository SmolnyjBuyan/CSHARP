int[] array = {2, 5, 2, 3, 6, 3, 7, 8, 2, 4};
int count = 0;

foreach (int a in array)
{
    if (a % 2 == 0) count++;
}
Console.WriteLine(count);
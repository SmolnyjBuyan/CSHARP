int[] arr = { 2, 6, 5, 56, 35, -34, 67, 76, 82, 32 };
int i = 0;

while (i < arr.Length)
{
    if (arr[i] % 2 == 0)
    {
        Console.Write($"{arr[i]} ");
    }
    i++;
}
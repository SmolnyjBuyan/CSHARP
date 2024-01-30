int number = 40;
if (number >= 10 && number <= 99)
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;
    int max;
    if (firstDigit > secondDigit)
    {
        max = firstDigit;
    }
    else
    {
        max = secondDigit;
    }
    Console.WriteLine($"{number} => {max}");
}
else
{
    Console.WriteLine("Условие: целое число из отрезка [10,99]");
}
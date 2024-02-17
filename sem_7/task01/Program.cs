// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.

// Пример
// 123 => 6
// 63 => 9

int SumOfDigits(int number)
{
    // Базовый случай 
    // 63 -> 3 + (63/10)
    // 63 -> 3 + 6 
    if (number / 10 == 0) return number;
    // Рекурсивный случай
    int result = number % 10 + SumOfDigits(number / 10);
    return result;
}
Console.WriteLine(SumOfDigits(56));
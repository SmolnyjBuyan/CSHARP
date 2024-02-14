bool IsStringPalindrome(string str)
{
    for (int i = 0; i < str.Length / 2; i++)
    {
        if (str[i] != str[str.Length - 1 - i]) return false;
    }
    return true;
}

string palindrome = string.Empty;
Console.Write("Введите слово: ");
while (true)
{
    palindrome = Console.ReadLine()!;
    if (palindrome == string.Empty) Console.WriteLine("Вы ничего не ввели, введите слово: ");
    else break;
}

if (IsStringPalindrome(palindrome.ToLower())) Console.WriteLine("Это слово является палиндромом!");
else Console.WriteLine("Это слово не является палиндромом!");
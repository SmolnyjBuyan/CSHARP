string CreateString(int length)
{
    string symbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
    string result = string.Empty;
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        result +=  symbols[rnd.Next(symbols.Length)];
    }
    return result;
}

string answer = CreateString(20);
Console.Write("Исходная строка: ");
Console.WriteLine(answer);
Console.Write("Строка, в которой все заглавные буквы заменены на строчные: ");
Console.WriteLine(answer.ToLower());
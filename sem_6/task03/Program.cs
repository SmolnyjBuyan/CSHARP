// Считать строку с консоли, состоящую из латинских
// букв в нижнем регистре. Выяснить, сколько среди
// введённых букв гласных.
// Пример
// “hello” => 2
// “world” => 1

int GetVovelsCount(string str)
{
    // str = “hello” , 'h'
    string vovels = "aoueyi"; // Гласные буквы в англ
    int vovelsCount = 0; // Количество гласных
    foreach (char symbol in str) // Получаю каждую букву
    {
        // "aa", symbol = "a", symbol = "a"
        // 'e' == a, o, u, e, y, i
        foreach (char vovel in vovels) // Получил гласные
        {
            if (symbol == vovel)
            {
                vovelsCount++; // Нашли гласную
                break; // Если нашли гласную, идем к след.символу строчки
            }
        }
    }
    return vovelsCount;
}

Console.Write("Введите строчку: ");
string inputString = Console.ReadLine();
inputString = inputString.ToLower(); // "HI" -> "hi"
// ToUpper(): "hi" -> "HI"
Console.WriteLine($"В строке: {inputString} : {GetVovelsCount(inputString)} гласных");
// Считать строку с консоли, содержащую латинские буквы.
// Вывести на экран согласные буквы этой строки.

// “hello” => h l l
// “World” => W r l d
// “Hello world!” => H l l w r l d

// hello -> ello -> llo -> lo -> o -> (0 букв - длина строки = 0)
void ShowConsonants(string str)
{
    // Базовый случай
    if (str.Length == 0)
    {
        return;
    }
    // Рекурсивный случай
    string vowels = "aoueyi"; // Гласные буквы
    // hello -> h == a, o, y, e, y, i и если это буква -> согласная
    if (char.IsLetter(str[0]) && !vowels.Contains(char.ToLower(str[0])))
    {
        Console.Write($"{str[0]} ");
    }
    // 'h' - 1 символ 
    ShowConsonants(str.Substring(1)); 
    // Я получаю строчку, начиная от 1 индекса в строчке
}

ShowConsonants("Hello world!");
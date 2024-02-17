// На основе символов строки (тип string) сформировать массив
// символов (тип char[]). Вывести массив на экран.
// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ]


char[] ConvertStringToCharArray (string str)
{
    char[] chars = new char[str.Length];
    // "hi" -> [,]
    // "hi" -> [str[0], str[1]]
    for (int i = 0; i < str.Length; i++)
    {
        chars[i] = str[i]; 
        // chars = [], str = "hi"
        // chars[0] = str[0]; chars = ['h',]
        // chars[1] = str[1]; chars = ['h','i']
    }
    return chars;
}

string str = "Hello world";
Console.WriteLine($"Строка: {str}");
char[] chars = ConvertStringToCharArray(str);
Console.WriteLine($"Массив: [ {string.Join("; ", chars)} ]");
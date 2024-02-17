// Задайте массив символов (тип char []). Создайте строку из
// символов этого массива. 
// [‘a’, ‘b’, ‘c’, ‘d’] => “abcd”

string GetStringFromCharArray(char[] array)
{
    string result = string.Empty; // ""
    foreach (char symbol in array)
    // symbol = 'a', symbol = 'b', symbol = 'c', symbol = 'd'
    {
        result = result + symbol;
        // res = "" + 'a', res = "a"
        // res = "a" + 'b', res = "ab"
        // res = "ab" + 'c', res = "abc"
        // res = "abc" + 'd', res = "abcd"
    }
    return result;
}

char[] chars = { '1', 'd', '!', '2', 'f' };
Console.WriteLine($"Массив: [ {string.Join("; ", chars)} ]");
string res = GetStringFromCharArray(chars);
Console.WriteLine(res);

Console.WriteLine(string.Join("", chars));
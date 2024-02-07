string GetNumbersFromString(string s)
{
    string numbers = "";
    foreach (char e in s)
    {
        if (char.IsAsciiDigit(e) == true)
        {
            numbers = numbers + e;
        }
    }
    return numbers;
}

int[] CreateArrayFromString(string text)
{
    int[] array = new int[text.Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = (int)Char.GetNumericValue(text[i]);
    }
    return array;
}


string str = Console.ReadLine();
string numbersFromString = GetNumbersFromString(str);
int[] result = CreateArrayFromString(numbersFromString);

Console.WriteLine($"[ {string.Join("; ", result)} ]");
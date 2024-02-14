string ReverseString(string str)
{
    string[] words = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
    for (int i = 0; i < (words.Length / 2); i++)
    {
        string temp = words[i];
        words[i] = words[words.Length - 1 - i];
        words[words.Length - 1 - i] = temp;
    }
    return String.Join(" ", words);
}

string ClearExtraSpacesFromStartAndEnd(string str)
{
    int i = 0;
    int j = (str.Length - 1);
    string result = string.Empty;

    while (str[i] == ' ') i++;
    while (str[j] == ' ') j--;

    while (i <= j)
    {
        result += str[i];
        i++;
    }
    return result;
}

string ClearExtraSpacesFromCentre(string str)
{
    string nerfedStr = ClearExtraSpacesFromStartAndEnd(str);
    string result = string.Empty;
    for (int i = 0; i < nerfedStr.Length; i++)
    {
        if (nerfedStr[i] == ' ' && nerfedStr[i - 1] == ' ') continue; 
        result += nerfedStr[i];
    }
    return result;
}

string ReverseStringByKotov(string str)
{
    string nerfedStr = ClearExtraSpacesFromCentre(str);
    int wordsCount = 1;
    foreach(char symbol in nerfedStr)
    {
        if (symbol == ' ') wordsCount++;
    }
    string[] words = new string[wordsCount];

    int j = 0;
    for (int i = 0; i < nerfedStr.Length; i++)
    {
        if (nerfedStr[i] == ' ')
        {
            j++;
            continue;
        }
        words[j] = words[j] + nerfedStr[i];
    }

    for (int i = 0; i < (words.Length / 2); i++)
    {
        string temp = words[i];
        words[i] = words[words.Length - 1 - i];
        words[words.Length - 1 - i] = temp;
    }

    string result = string.Empty;
    for (int i = 0; i < words.Length - 1; i++)
    {
        result += $"{words[i]} ";
    }
    result += words[words.Length - 1];
    return result;
}

string someSentence = "        Шла     Саша по            шоссе                ";
Console.WriteLine(ReverseString(someSentence));
Console.WriteLine(ReverseStringByKotov(someSentence) + '!');
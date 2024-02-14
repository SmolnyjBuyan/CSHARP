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

string someSentence = "Шла     Саша по шоссе";
Console.WriteLine(ReverseString(someSentence));


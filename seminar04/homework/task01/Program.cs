bool BreakProgram(string? text)
{
    if (text == "q") return true;

    if (int.TryParse(text, out int number))
    {
        int sum = 0;
        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }
        if (sum % 2 == 0) return true;
    }
    return false;
}

while (true)
{
    Console.Write("Введите число:");
    string? input = Console.ReadLine();
    if (BreakProgram(input) == true) break;
}





// while (true)
// {
//     Console.Write("Введите число:");
//     string? text = Console.ReadLine();
//     if (text == "q") break;

//     int number;
//     if (int.TryParse(text, out number))
//     {
//         int sum = 0;
//         while (number > 0)
//         {
//             sum += number % 10;
//             number /= 10;
//         }
//         if (sum % 2 == 0) break;
//     }
// }

// Your task is to make a function that can take any non-negative integer as an argument and return it with its digits in descending order.
// Essentially, rearrange the digits to create the highest possible number.

// Examples:
// Input: 42145 Output: 54421

// Input: 145263 Output: 654321

// Input: 123456789 Output: 987654321

int num = 42145;
string result = num.ToString();


int[] answer = result.OrderByDescending(x => x).ToArray();





// int num = 42145;
// string result = string.Concat(num.ToString().OrderByDescending(x => x));

//int answer = Int32.Parse(String.Join("",result));
// Console.WriteLine(result);


// int[] arr = new int[5];
// int i = 0;
// while (num > 0)
// {
//     arr[i] = num % 10;
//     num /= 10;
//     i++;
// }

// Array.Sort(arr);
// Array.Reverse(arr);

// foreach (int a in arr)
// {
//     Console.Write($"{a} ");
// }

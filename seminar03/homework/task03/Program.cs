double[] array = { 0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01 };
double max = array[0];
double min = array[0];

for (int i = 1; i < array.Length; i++)
{
    if (array[i] > max) max = array[i];
    if (array[i] < min) min = array[i];
}


Console.WriteLine(max - min);
Console.WriteLine(array.Min());
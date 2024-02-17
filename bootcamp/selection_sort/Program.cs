void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-20, 21);
}

int[] SortArrayBySelection(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int indexMin = i;
        for (int j = i; j < array.Length; j++)
        {
            if (array[j] < array[indexMin])
                indexMin = j;
        }
        if (array[indexMin] == array[i])
            continue;

        int temp = array[i];
        array[i] = array[indexMin];
        array[indexMin] = temp;
    }
    return array;
}

Console.Clear();
Console.Write("Ввидете кол-во элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [ {string.Join(", ", array)} ]");
Console.WriteLine($"Конечный массив: [ {string.Join(", ", SortArrayBySelection(array))} ]");


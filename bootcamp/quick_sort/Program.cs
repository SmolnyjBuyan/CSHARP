// Напишите программу, которая сложит два числа a и b без прямого соединения

// int sumNumbers(int n, int m)
// {
//     if (m == 0) return n;
//     return sumNumbers(n + 1, m - 1);
// }

// Console.Clear();
// Console.Write("Введите первое число: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите второе число: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"{a} + {b} = {sumNumbers(a, b)}");

/*
Структура кода:
1) импорт всех модулей, библиотек, объектов
2) Объекты и методы
3) Функции и процедуры
4) Основной программный код
*/
T[] Concat<T>(params T[][] arrays){ // [1, 2, 3] [3, 4] [5, 6, 7, 8]
    var result = new T[arrays.Sum(a => a.Length)]; // [0, 0, 0, 0, 0, 0, 0, 0]
    // arrays = [[1, 2, 3], [3, 4], [5, 6, 7, 8]]
    // a = [1, 2, 3] -> 3
    int offset = 0;
    foreach(T[] array in arrays){
        array.CopyTo(result, offset); // [1, 2, 3, 3, 4, 5, 6, 7, 8]
        offset += array.Length; // offset = 3 + 2 = 5
    }
    return result;
}


int[] quickSort(int[] array){
    if (array.Length < 2){
        return array;
    }
    else{
        int pivot = array[0];
        int count = 0;
        foreach (int element in array){
            if (element < pivot)
                count++;
        }
        int[] less = new int[count];
        int j = 0;
        for (int i = 0; i < array.Length; i++){
            if (array[i] < pivot){
                less[j] = array[i];
                j++;
            }
        }
        count = 0;
        foreach (int element in array){
            if (element > pivot)
                count++;
        }
        int[] greater = new int[count];
        j = 0;
        for (int i = 0; i < array.Length; i++){
            if (array[i] > pivot){
                greater[j] = array[i];
                j++;
            }
        }
        count = 0;
        foreach (int element in array){
            if (element == pivot)
                count++;
        }
        int[] pivotArray = new int[count];
        for (int i = 0; i < count; i++){
            pivotArray[i] = pivot;
        }
        int[] result = Concat(quickSort(less), pivotArray, quickSort(greater));
        return result;
    }
}


Console.Clear();
int[] array = {7, 4, 1, 3, 5, 2, 8, 6};
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Отсортированный массив: [{string.Join(", ", quickSort(array))}]");
﻿// Комментарий
/*
Это многострочный комментарий
*/
// Напишите программу, которая на вход
// принимает два целых числа и проверяет,
// является ли первое число квадратом второго.
// a = 25, b = 5 => да
// a = 2, b = 10 => нет
// a = 9, b = -3 => да
// a = -3, b = 9 => нет

//тип_данных имяПеременной = значение
// int firstNumber = 25;
// int secondNumber = 5;
// // "==" проверка на равенство: 5 == 5(true), 4 == 5 (false)
// // secondNumber * secondNumber == firstNumber
// if (secondNumber * secondNumber == firstNumber)
// {
//     Console.WriteLine("Да"); // 1 число является квадратом 2 числа
// }
// else // 1 число не является квадратом 2 числа
// {
//     Console.WriteLine("Нет");
// }

// Напишите программу, которая на вход принимает
// целое число N, а на выходе показывает все целые
// числа в промежутке от -N до N.
// Примеры
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2

// int N = 4;
// int negativeN = -N; // negativeN = -4

// while (negativeN <= N)
// {
//     Console.Write(negativeN + " ");
//     // Конкатенация: "Привет" + "Мир" = "ПриветМир"
//     negativeN++;
// }

// Напишите программу, которая принимает на вход
// трёхзначное целое число и на выходе показывает сумму
// первой и последней цифры этого числа.
// 456 => 10
// 782 => 9
// 918 => 17

// int number = 435; // 4 + 5 = 9
// int firstDigit = number / 100; // 435 / 100 = 4
// int thirdDigit = number % 10; // 435 % 10 = 5
// int res = firstDigit + thirdDigit;
// Console.WriteLine("Результат: " + res);

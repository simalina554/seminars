﻿/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
using System;
int rowCount = 3; // Количество строк
int columnCount = 4; // Количество столбцов
string[,] array = GenerateRandomArray(rowCount, columnCount, 0, 100);
Console.WriteLine(array);
    static void Main()
    {
        int rowCount = 3; // Количество строк
        int columnCount = 4; // Количество столбцов

        string[,] array = GenerateRandomArray(rowCount, columnCount, 0, 100);
        
        // Выводим сгенерированный двумерный массив строк на консоль
        for (int i = 0; i < rowCount; i++)
        {
            for (int j = 0; j < columnCount; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static string[,] GenerateRandomArray(int rowCount, int columnCount, int minValue, int maxValue)
    {
        Random random = new Random();
        string[,] array = new string[rowCount, columnCount];

        for (int i = 0; i < rowCount; i++)
        {
            for (int j = 0; j < columnCount; j++)
            {
                int randomNumber = random.Next(minValue, maxValue + 1); // Генерируем случайное число в заданном диапазоне
                array[i, j] = randomNumber.ToString(); // Преобразуем число в строку и сохраняем в массив
            }
        }

        return array;
    }

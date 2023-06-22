//Задача 55:**Задайте двумерный массив.
// Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// В итоге получается вот такой массив:
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

using System;
using static System.Console;

Write("stroki: ");
int rows = int.Parse(ReadLine());
Write("stolbci: ");
int columns = int.Parse(ReadLine());

int[, ] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Write("/");
ColToRow(array);

int[, ] GetArray(int m, int n, int min, int max){
    int[, ] result = new int[m, n];
    for(int i = 0; i<m; i++){
        for(int j=0; j<n; j++){
            result[i, j] = new Random().Next(min, max+1);
        }
    }
    return result;
}

void ColToRow(int [,] array2){
    for(int i = 0; i<array2.GetLength(1); i++){
        for(int j = 0; j<array2.GetLength(0); j++){
            Write($"{array2[j, i], 3} ");
        }
        WriteLine();
    }
}


void PrintArray(int[, ] array2){
    for(int i = 0; i < array2.GetLength(0); i++){
        for (int j=0; j<array2.GetLength(1); j++){
            Write($"{array2[ i, j]} ");
        }
        WriteLine();
    }
}
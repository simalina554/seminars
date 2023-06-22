// **Задача 48:** Задайте
// двумерный массив размера m на n, каждый элемент
// в массиве находится по формуле: A[i, j] = i + j.
//Выведите полученный массив на экран.
using System;
using static System.Console;

Write("stroki: ");
int rows = int.Parse(ReadLine());
Write("stolbci: ");
int columns = int.Parse(ReadLine());

int[, ] array = GetArray(rows, columns);
PrintArray(array);
int[, ] GetArray(int m, int n){
    int[, ] result = new int[m, n];
    for(int i = 0; i<m; i++){
        for(int j=0; j<n; j++){
            result[i, j] = i + j;
        }
    }
    return result;
}

void PrintArray(int[, ] inArray){
    for(int i = 0; i < inArray.GetLength(0); i++){
        for (int j=0; j<inArray.GetLength(1); j++){
            Write($"{inArray[i, j]}");
        }
        WriteLine();
    }
}
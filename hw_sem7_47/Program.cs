/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
using System;
using static System.Console;

Write("stroki: ");
int rows = int.Parse(ReadLine());
Write("stolbci: ");
int columns = int.Parse(ReadLine());

double[, ] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

double[, ] GetArray(int m, int n, int min,int max){
    double[,] array = new double[m, n];
    Random random = new Random();
    for (int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){
            array[i, j] = random.NextDouble();
        }
    }
    return array;
}

void PrintArray(double[, ] inArray){
    for(int i = 0; i < inArray.GetLength(0); i++){
        for (int j=0; j<inArray.GetLength(1); j++){
            Write($"{inArray[i, j]}  ");
        }
        WriteLine();
    }
}
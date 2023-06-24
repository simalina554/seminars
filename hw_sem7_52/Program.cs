/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

using System;
using static System.Console;

Write("stroki: ");
int rows = int.Parse(ReadLine());
Write("stolbci: ");
int columns = int.Parse(ReadLine());
int[, ] array= GetArray(rows, columns, 0, 10);
PrintArray(array);
double[] avgSum = SumAvg(array);
Write(String.Join("; ", avgSum));

int[, ] GetArray(int m, int n, int min, int max){
    int[, ] result = new int[m, n];
    for(int i = 0; i<m; i++){
        for(int j=0; j<n; j++){
            result[i, j] = new Random().Next(min, max+1);
        }
    }
    return result;
}

double[] SumAvg(int[,] array){
    double[] result = new double[array.GetLength(1)];
    double sum=0;
    for (int i = 0; i < array.GetLength(1); i++){   
        for (int j = 0; j < array.GetLength(0); j++){
            sum += array[j, i];
        }
        result[i]=sum / array.GetLength(1);
    }
    return result;
}

void PrintArray(int[, ] inArray){
    for(int i = 0; i < inArray.GetLength(0); i++){
        for (int j=0; j<inArray.GetLength(1); j++){
            Write($"{inArray [i, j ]} ");
        }
        WriteLine();
    }
}
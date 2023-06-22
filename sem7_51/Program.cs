// Задача 51: Задайте двумерный массив.
// Найдите сумму элементов, находящихся
// на главной диагонали (с индексами (0,0); (1; 1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
using System;
using static System.Console;

Write("stroki: ");
int rows = int.Parse(ReadLine());
Write("stolbci: ");
int columns = int.Parse(ReadLine());

int[, ] array= GetArray(rows, columns);
PrintArray(array);
Write(GetSum(array));

int[, ] GetArray(int m, int n){
    int[, ] result = new int[m, n];
    for(int i = 0; i<m; i++){
        for(int j=0; j<n; j++){
            result[i, j] = i + j;
        }
    }
    return result;
}
int GetSum(int [,] array){
    int sum = 0;
    for(int i = 0; i<array.GetLength(0); i++){
        for(int j=0; j<array.GetLength(1); j++){
            if(i==j){
                sum = sum + array[i, j];
            }
        }
    }
    return sum;
}

void PrintArray(int[, ] inArray){
    for(int i = 0; i < inArray.GetLength(0); i++){
        for (int j=0; j<inArray.GetLength(1); j++){
            Write($"{ inArray [ i, j ]}");
        }
        WriteLine();
    }
}
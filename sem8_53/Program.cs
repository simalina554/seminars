//53
/**Задача 53:**Задайте двумерный массив.
Напишите программу, которая поменяет местами первую и последнюю строку массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
8 4 2 4
5 9 2 3
1 4 7 2*/

using System;
using static System.Console;

Write("stroki: ");
int rows = int.Parse(ReadLine());
Write("stolbci: ");
int columns = int.Parse(ReadLine());

int[, ] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Write("/");
PrintArray(GetArray2(array));

int[, ] GetArray(int m, int n, int min, int max){
    int[, ] result = new int[m, n];
    for(int i = 0; i<m; i++){
        for(int j=0; j<n; j++){
            result[i, j] = new Random().Next(min, max+1);
        }
    }
    return result;
}

int[, ] GetArray2(int [,] array2){
    for(int i = 0; i<array2.GetLength(1); i++){
            int b = array2[0, i];
            array2[0, i] = array2[array2.GetLength(0)-1, i];
            array2[array2.GetLength(0)-1, i] = b;
    }
    return array2;
}


void PrintArray(int[, ] array2){
    for(int i = 0; i < array2.GetLength(0); i++){
        for (int j=0; j<array2.GetLength(1); j++){
            Write($"{array2[ i, j]} ");
        }
        WriteLine();
    }
}
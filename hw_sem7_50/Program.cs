/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

using System;
using static System.Console;

Write("stroki: ");
int rows = int.Parse(ReadLine());
Write("stolbci: ");
int columns = int.Parse(ReadLine());
int[, ] array= GetArray(rows, columns, 0, 10);
Write("number: ");
int num = int.Parse(ReadLine());
PrintArray(array);
Write(Num(array, num));

int[, ] GetArray(int m, int n, int min, int max){
    int[, ] result = new int[m, n];
    for(int i = 0; i<m; i++){
        for(int j=0; j<n; j++){
            result[i, j] = new Random().Next(min, max+1);
        }
    }
    return result;
}

string Num(int [,] array, int num){
    string res = "";
    for(int i = 0; i<array.GetLength(0); i++){
        for(int j=0; j<array.GetLength(1); j++){
            if(array[i, j] != num){
                res = "no";
            }
            else
                res = "yes";
        }
    }
    return res;
}

void PrintArray(int[, ] inArray){
    for(int i = 0; i < inArray.GetLength(0); i++){
        for (int j=0; j<inArray.GetLength(1); j++){
            Write($"{inArray [i, j ]} ");
        }
        WriteLine();
    }
}
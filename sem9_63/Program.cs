﻿/* **Задача 63:**Задайте значение N.Напишите программу,
 которая выведет все натуральные числа в промежутке от 1 до N.

N = 5-> "1, 2, 3, 4, 5"

N = 6-> "1, 2, 3, 4, 5, 6"
*/

using System;
using static System.Console;
/*
Write("Введите N: ");
int n= int.Parse(ReadLine());

for (int i = 1; i <= n; i++){
    Write($"{i} ");
}
WriteLine();
WriteLine(PrintNumbers(n));

string PrintNumbers(int n){
    if (n == 1)
    {
        WriteLine(1);
        return "1";
    }
    string s = PrintNumbers(n - 1) + ", " + n.ToString();
    WriteLine(s);
    return s;
}*/
void Numbers(int n, int i){
    if(i<=n){
        Write($"{i}, ");
        i++;
        Numbers(n,i);
    }
}
Numbers(6, 1);
/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

using System;
using static System.Console;

Write("Введите M: ");
int m = int.Parse(ReadLine());
Write("Введите N: ");
int n = int.Parse(ReadLine());


int PrintNum(int m, int n){
    int sum = 0;
    if(m==n){
        //WriteLine(m);
        return m;
    }
    else{
        sum =m + PrintNum(m+1, n);
        return sum;
    }
}
WriteLine(PrintNum(m, n));
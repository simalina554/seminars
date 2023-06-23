/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

using System;
using static System.Console;

Write("Введите N: ");
int n = int.Parse(ReadLine());

void Numbers(int n, int i){
    if(i<=n){
        Write($"{n}, ");
        n--;
        Numbers(n,i);
    }
}
Numbers(n, 1);
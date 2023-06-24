﻿/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
using System;
using static System.Console;

int Akerman(int m, int n){
    if(m==0){
        return n+1;
    }
    else if(n==0 && m>0){
        return Akerman(m-1, 1);
    }
    else{
        return Akerman(m-1, Akerman(m, n-1));
    }
}
WriteLine(Akerman(3, 2));


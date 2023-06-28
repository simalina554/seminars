//69 Напишите программу, которая на вход принимает два числа A и B, 
//и возводит число А в натуральную степень B с помощью рекурсии.
using System;
using static System.Console;

int Step(int a, int b){
    if (b==1){
        return a;
    }
    else{
        int c = Step(a, b-1) * a;
        return c;        
    }
}
WriteLine(Step(2, 3));

/*Clear();
Write("Введите число: ");
int m = int.Parse(ReadLine());
Write("Введите степень: ");
int n = int.Parse(ReadLine());

WriteLine($"{Pow(m, n)}");
int res = m;
for (int i = 0; i < n; i++)
{
    m *= res;
}
int Pow(int number, int rank)
{
    if (rank == 0) 
        return 1;
    return (number * Pow(number, rank - 1));
}
*/
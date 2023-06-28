/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
Console.Clear();
Console.Write("num: ");
int a = int.Parse(Console.ReadLine());
Console.Write("ctepen: ");
int b = int.Parse(Console.ReadLine());
int res = 1;
int GetProiz(int a, int b){
    for (int i=1; i<= b; i++)
        res *= a;
    return res;
}

Console.WriteLine($"{GetProiz(a, b)} ");

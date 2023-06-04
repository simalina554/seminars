/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
int res = 0;
int GetKol(int n){
    while(n > 0){
        res = res + n % 10;
        n = n /10;
    }
    return res;
}
Console.Clear();
Console.Write("num: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"{num} - {GetKol(num)}");
//26 Напишите программу,
//которая принимает на вход число и выдаёт
//количество цифр в числе.

// 456 -> 3
// 78 -> 2
// 89126 -> 5
int res = 0;
int GetKol(int n){
    while(n > 0){
        n /= 10;
        res++;
    }
    return res;
}
Console.Clear();
Console.Write("num: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"{num} - {GetKol(num)}");

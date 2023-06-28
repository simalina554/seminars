//28 Напишите программу, которая принимает на вход число N 
//и выдаёт произведение чисел от 1 до N.
//4-> 24
//5-> 120 == 1 * 2 * 3 * 4 * 5
Console.Clear();
Console.Write("num: ");
int n = int.Parse(Console.ReadLine());
int res = 1;
int GetProiz(int n){
    for (int i=1; i<= n; i++)
        res *= i;
    return res;
}
Console.WriteLine($"{GetProiz(n)} ");


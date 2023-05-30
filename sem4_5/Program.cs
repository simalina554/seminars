//30 Напишите программу, которая выводит массив из 8 элементов, 
//заполненный нулями и единицами в случайном порядке.
Console.Clear();
Console.Write("num: ");
int a = int.Parse(Console.ReadLine());
int[] GetArr(int n)
{
    int[] arr = new int[a];
    for (int i = 0; i < a; i++)
    {
        arr[i] = new Random().Next(0, 2);
    }
    return arr;
}
int [] arr =  GetArr(a);
for (int i = 0; i < a; i++)
{
    Console.Write($"{arr[i]}");
    //Console.WriteLine($"[{String.Join("; ---", array)}]");
}
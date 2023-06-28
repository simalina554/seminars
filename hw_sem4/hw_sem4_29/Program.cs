
/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
Console.Clear();
Console.Write("num: ");
int n = int.Parse(Console.ReadLine());
int res = 0;
int [] GetMass(int n){
    int [] arr = new int[n];
    for(int i = 0; i < n; i++){
        arr[i] = new Random().Next(10);
    }
    return arr;
}
int [] arr = GetMass(n);
for(int i=0 ; i<n; i++){
    Console.Write(arr[i]);
}
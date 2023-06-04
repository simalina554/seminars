/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
//1
int [] GetRanArr(int size){
    int [] res = new int[size];
    for (int i = 0; i< size; i++){
        res[i] = new Random().Next(100, 1000);
    }
    return res;
}
int k = 0;
int GetPol(int [] arr){
    int [] res = new int[2];
    foreach(int el in arr){
        if(el % 2==0){
            k++;
        }
    }
    return k;
}

int [] arr = GetRanArr(12);
Console.WriteLine($"[{String.Join(", ", arr)}]");

Console.WriteLine($"[{GetPol(arr)}]");

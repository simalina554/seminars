/*Задача 32:**Напишите программу замена элементов массива:
положительные элементы замените на соответствующие отрицательные, и наоборот.

[-4, -8, 8, 2] -> [4, 8, -8, -2] String.Join(", ", array)*/

int [] arr = GetRanArr(12, -9, 9);
Console.WriteLine(String.Join(", ", arr));
SumPN(arr);
Console.WriteLine(String.Join(", ", arr));


int [] GetRanArr(int size, int min, int max){
    int [] res = new int[size];
    for (int i = 0; i < size; i++){
        res[i] = new Random().Next(min, max+1);
    }
    return res;
}

int [] SumPN(int [] arr){
    int [] res = new int[2];
    for(int i=0; i < arr.Length; i++){
        arr[i] *= -1;
    }
    return arr;
}


/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
Console.WriteLine("dd:" );
int n = int.Parse(Console.ReadLine());

int [] GetArr(int size){
    int [] res = new int[size];
    for (int i = 0; i< size; i++){
        res[i] = new Random().Next(0, 100);
    }
    return res;
}

int a = 0;
int Sum(int [] arr){
    for(int i = 0; i<n; i++){
        if(i % 2 != 0){
            a = arr[i] + a;
        }
    }

    return a;
}


int [] arr = GetArr(n);
Console.WriteLine(String.Join(", ", arr));
Console.WriteLine(Sum(arr));


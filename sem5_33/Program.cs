/* Задача 33:**Задайте массив.Напишите программу,
которая определяет, присутствует ли заданное число в массиве.

4; массив[6, 7, 19, 345, 3]->нет
3; массив[6, 7, 19, 345, 3]->да*/
Console.WriteLine("eg:" );
int r = int.Parse(Console.ReadLine());

int [] GetRanArr(int size){
    int [] res = new int[size];
    for (int i = 0; i< size; i++){
        res[i] = new Random().Next(0, 10);
    }
    return res;
}
string f = "";
string SumPN(int [] arr,int num){
    //int [] res = new int[2];
    foreach(int el in arr){
        if(el == num){
            f = "yes";
        }
        else if(el != num){
            f = "no";
        }
    }
    return f;
}

int [] arr = GetRanArr(12);
Console.WriteLine(String.Join(", ", arr));
//int [] r = SumPN(arr);
Console.WriteLine($"[{SumPN(arr, r)}]");

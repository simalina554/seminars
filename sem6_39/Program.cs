//39 //Напишите программу, которая перевернёт одномерный массив
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)
int [] array = GetArray(10, 0, 10);
Console.WriteLine(String.Join(" ", array));
ReversArray(array);
Console.WriteLine(String.Join(" ", array));
Console.WriteLine(String.Join(" ", ReversArray2(array)));
Console.WriteLine(String.Join(" ", array));

int[] GetArray(int size, int min, int max){
    int[] res = new int[size];
    for (int i = 0; i<size; i++){
        res[i] = new Random().Next(min, max + 1);
    }
    return res;
}
//1 way

void ReversArray(int[] inArray){
    for (int i=0; i< inArray.Length / 2; i++){
        int k = inArray[i];
        inArray[i] = inArray[inArray.Length - i - 1];
        inArray[inArray.Length-i - 1] = k;
    }
}
//2 way

int[] ReversArray2(int[] inArray){
    int [] result = new int[inArray.Length];
    for (int i = 0; i< inArray.Length; i++){
        result[i] = inArray[inArray.Length - 1 - i];
    };
    return result;
}
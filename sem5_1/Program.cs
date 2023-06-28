//1
int [] GetRanArr(int size, int min, int max){
    int [] res = new int[size];
    for (int i = 0; i< size; i++){
        res[i] = new Random().Next(min, max + 1);
    }
    return res;
}

int [] SumPN(int [] arr){
    int [] res = new int[2];
    foreach(int el in arr){
        res[0] += el > 0 ? el : 0;
        /*
        if(el> 0){
            res[0] += el;
        else
            res[0] += 0;
        }
        */
        res[1] += el < 0 ? el:0 ;
    }
    return res;
}

int [] arr = GetRanArr(12, -9, 9);
Console.WriteLine(String.Join(", ", arr));
int [] r = SumPN(arr);
Console.WriteLine($"positive = {r[0]}, negative = {r[1]}");
Console.WriteLine($"[ {String.Join(", ", arr)} ]");

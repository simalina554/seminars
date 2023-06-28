int GetSum(int n){
    int sum = 0;
    for(int i = 1; i<= n; i++)
        sum += i;
    
    return sum;
}

Console.Clear();
Console.Write("num: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"cum from 1 to {num} = {GetSum(num)}");
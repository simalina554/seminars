//4
Console.Clear();
Console.Write("Number 1: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Number 2: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Number 3: ");
int c = int.Parse(Console.ReadLine());
if (a>b && a>c){
    Console.WriteLine($"Максимальное число: {a}");
}
else if (a<b && b>c){
    Console.WriteLine($"Максимальное число: {b}");
}
else{
    Console.WriteLine($"Максимальное число: {c}");
}

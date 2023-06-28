//10
Console.Clear();
Console.Write("Number: ");
int num1 = int.Parse(Console.ReadLine());
int s = num1 %100;
int e = s / 10;
Console.Write($"{e}");

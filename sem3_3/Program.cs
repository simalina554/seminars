//20
Console.Clear();
Console.Write("X: ");
int X = int.Parse(Console.ReadLine());
Console.Write("Y: ");
int Y = int.Parse(Console.ReadLine());
Console.Write("X2: ");
int X2 = int.Parse(Console.ReadLine());
Console.Write("Y2: ");
int Y2 = int.Parse(Console.ReadLine());
double s = Math.Sqrt((X-X2)*(X-X2) + (Y - Y2)*(Y - Y2));
Console.WriteLine($"dgtrhth:{s:f4}");



// 20 Напишите программу,
// которая принимает на вход координаты двух точек и находит
// расстояние между ними в 2D пространстве.
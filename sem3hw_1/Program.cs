//21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.Write("X: ");
int X = int.Parse(Console.ReadLine());
Console.Write("Y: ");
int Y = int.Parse(Console.ReadLine());
Console.Write("Z: ");
int Z = int.Parse(Console.ReadLine());
Console.Write("X2: ");
int X2 = int.Parse(Console.ReadLine());
Console.Write("Y2: ");
int Y2 = int.Parse(Console.ReadLine());
Console.Write("X2: ");
int Z2 = int.Parse(Console.ReadLine());
double s = Math.Sqrt((X-X2)*(X-X2) + (Y - Y2)*(Y - Y2) + (Z - Z2)*(Z - Z2));
Console.WriteLine($"A({X},{Y},{Z}); B({X2},{Y2},{Z2}) : {s:f2}");
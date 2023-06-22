// **Задача 40:**Напишите программу,
// которая принимает на вход три числа и проверяет, может ли
// существовать треугольник с сторонами такой длины.
// ❗ **Теорема о неравенстве треугольника:
// **каждая сторона треугольника меньше суммы двух других сторон.

Console.WriteLine("Введите последовательно три числа:");
int AB = Convert.ToInt32(Console.ReadLine());
int BC = Convert.ToInt32(Console.ReadLine());
int CA = Convert.ToInt32(Console.ReadLine());

bool SidesCompare(int x, int y, int z)
{
return x < y + z && y < x + z && z < y + x;
}
if(SidesCompare(AB, BC, CA))
{
Console.WriteLine("Треугольник существует");
}
else{
Console.WriteLine("Треугольник не существует");
}
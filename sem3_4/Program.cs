//Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу квадратов чисел от 1 до N.
Console.Clear();
Console.Write("X: ");

int X = int.Parse(Console.ReadLine());
/*
for (int i = 1; i <= X; i++){
    Console.Write($"{Math.Pow(i, 2)}; " );
}
*/

int[] res = new int[X];
for (int i = 1; i<= X; i++)
    res[i-1] = i * i;
//for (int i = 0; i< X; i++)
//    Console.Write($"{res[i]} ");
for (int i = 1; i<= X; i++)
    Console.Write($"{i*i} ");

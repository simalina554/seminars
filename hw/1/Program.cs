//1
//На столе лежат n монеток. Некоторые из них лежат вверх решкой,
//а некоторые – гербом. Определите минимальное число монеток, которые нужно перевернуть,
//чтобы все монетки были повернуты вверх одной и той же стороной.
//1-Решка
//0-Орел
Console.Clear();
Console.Write("n: ");
int n = int.Parse(Console.ReadLine());
int g = 0;
int o = 0;
for (int i=1; i<= n; i++ ){
    Console.Write("1 or 0: ");
    int go = int.Parse(Console.ReadLine());
    if (go == 1){
        g ++;
    }
    else{
        o++;
    }
}
if (g>o){
    Console.Write($"o: {o}");
}
else{
    Console.Write($"g: {g}");
}
Console.Clear();
Console.Write("X: ");
int X = int.Parse(Console.ReadLine());
Console.Write("Y: ");
int Y = int.Parse(Console.ReadLine());
if(X>0 && Y>0){
    Console.WriteLine("1");
} else if(X < 0 && Y>0){
    Console.WriteLine("2");
}else if(X < 0 && Y < 0){
    Console.WriteLine("3");
}else if(X > 0 && Y < 0){
    Console.WriteLine("4");
}else if(X==0 || Y==0){
    Console.WriteLine("На оси");
}
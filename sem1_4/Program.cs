//6
Console.Clear();
Console.Write("Number : ");
int a = int.Parse(Console.ReadLine());
int s = a%2;
if (s==0){
    Console.WriteLine("чётное");
}
else{
    Console.WriteLine("не чётное");
}
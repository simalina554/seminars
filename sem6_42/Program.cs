// **Задача 42:**Напишите программу,
// которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10
Console.WriteLine(" " );
int num = int.Parse(Console.ReadLine());
Console.Write(Decimal(num));
string Decimal(int n){
    string binar = "";
    while(n > 0){
        binar = Convert.ToString(n % 2)+ binar;
        n = n / 2;
    }
    return binar;
}

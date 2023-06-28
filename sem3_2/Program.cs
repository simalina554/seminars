//19
Console.Clear();
Console.Write("XY: ");
int XY = int.Parse(Console.ReadLine());
/*
if (XY == 1){
    Console.WriteLine("trs: [+; +]");
}else if (XY == 2){
    Console.WriteLine("trs: [-; +]");
}else if (XY == 3){
    Console.WriteLine("trs: [-; -]");
}else if (XY == 4){
    Console.WriteLine("trs: [+; -]");
}else if(XY < 1 || XY > 4){
    Console.WriteLine("rewrite");
}

*/
switch(XY){
    case 1:{
        Console.WriteLine("trs: [+; +]");
        break;
    }    
    case 2:{
        Console.WriteLine("trs: [-; +]");
        break;
    }   
    case 3:{
        Console.WriteLine("trs: [-; -]");
        break;
    }    
    case 4:{
        Console.WriteLine("trs: [-; +]");
        break;
    }
    default:{
        Console.WriteLine("fck you");
        break;
    }
}

// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).
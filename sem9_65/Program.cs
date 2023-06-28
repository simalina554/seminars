

using System;
using static System.Console;

Clear();
string PrintNum(int m, int n){
    if(m==n){
        //WriteLine(m);
        return m.ToString();
    }
    else{
        string a = PrintNum(m, n-1) + ", " + n.ToString();
        return a;
    }
}
WriteLine(PrintNum(3, 3));

using System;

namespace Extension_method
{
    class Program
    {
        static void Main(string[] args)
        {

A a = new A();
a.Mul(5,3);
a.Div(8,3);
       
        }
    }
    class A{
void add(int a, int b){
Console.WriteLine(a+b);    
}
void sub(int a, int b){
Console.WriteLine(a-b);    
}

    }
    static class B{
public static void Mul(this A i,int a, int b){
Console.WriteLine(a*b);    
}
public static void Div(this A i,int a, int b){
Console.WriteLine(a/b);    
}


}
  
}

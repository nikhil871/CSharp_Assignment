using System;
namespace MethodParameter{
class Parameters{
static string s= "red";
int type;
 // referenced para
 public static void Change(ref string s){
s="blue";
 }
//out
public static void Changebyout(out string s){
    s="green";
}
//default or optional para
public static void getDetails(string col,int quant=10,string type="na"){
    Console.WriteLine(type);
 Console.WriteLine(col);
  Console.WriteLine(quant);

}
// dynamic para
public static void display(dynamic s){
    s+=s;
    Console.WriteLine(s);
}
// value para
public static void add(int a,int b ){
    int c = a+b;
    Console.WriteLine(c);
}
public static void printString(){
    Console.WriteLine(s);
}
// paramas parameter
public static void Main(string[] args){
printString();
Change(ref s);
printString();
Changebyout(out s);
printString();
 getDetails("flower",10);
add(5,4);
display(5);
display("ready");

}

}


}
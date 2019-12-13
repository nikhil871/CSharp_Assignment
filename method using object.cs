using System;
namespace method{
public class ObjMethod{
    private string s;
    ObjMethod(string s){

        this.s= s;
    }
    ObjMethod(){}
    void display(){
        Console.WriteLine(this.s);
    }
   public ObjMethod GetObj(ObjMethod m) {
ObjMethod obj= new ObjMethod();
obj.s=s+m.s;
return obj;
   }
static void Main(){
    ObjMethod ob2= new ObjMethod("nice");
    ObjMethod ob1= new ObjMethod("to");
    ObjMethod ob3 = ob2.GetObj(ob1);
ob2.display();
ob3.display();
}
}
}
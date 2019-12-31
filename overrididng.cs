using System;

namespace overriding
{
    class A{
        public A(){
            Console.WriteLine("base constructer calling");
        }
         public A(int a){
            Console.WriteLine("base constructer calling "+a+" times");
        }
        public virtual void run(){
            Console.WriteLine("base class running");
        }
    }
    class B : A
    {
         public B() : base(5){
            
            Console.WriteLine("derived constructer calling");
        }
 public override void run(){
            Console.WriteLine("Derived class running");
        }
        static void Main(string[] args)
        {
         
A b = new B(); 
b.run();
       }
    }
}

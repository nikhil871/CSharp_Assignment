using System;

namespace MethodOverloading
{
    class Program
    {
        
        public void add(int a, int b){
            int c = a+b;
            Console.WriteLine("Sum of"+a+"and"+b+"is"+c);
        }
        // method overloading
          public void add(int a, int b, int c){
            int d = a+b+c;
            Console.WriteLine("Sum of"+a+","+c+"and"+b+"is"+c);
        }
        static void Main(string[] args)
        {
            Program program= new Program();
            program.add(1,2);
            program.add(1,2,3);
        }
    }
}

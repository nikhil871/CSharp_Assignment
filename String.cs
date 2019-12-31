using System;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
        string p= Name();

           Console.WriteLine(p[3]);
            Console.WriteLine(p.Contains("hn "));
            Console.WriteLine(p.ToUpper());
            Console.WriteLine(p.Substring(5,1));
          Console.WriteLine(Math.Max(25,35));


        }
        static string Name(){
return Console.ReadLine();
        }
    }
}

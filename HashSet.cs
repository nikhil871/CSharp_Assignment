using System;
using System.Collections.Generic;
namespace HashSet_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> h =new HashSet<int>();
            h.Add(5);
            h.Add(2);
            h.Add(4);
            h.Add(6);
            h.Add(7);
            h.Add(8);
            HashSet<int> p =new HashSet<int>();
            p.Add(3);
            p.Add(15);
            p.Add(16);
            p.Add(61);
            p.Add(7);
            p.Add(8);

            
            Console.WriteLine("Union Operation");
            h.UnionWith(p);
             foreach(int a in h){
                Console.WriteLine(a); 


            }  
                Console.WriteLine("Intersection Operation");
                h.IntersectWith(p);
                foreach(var a in h){
                Console.WriteLine(a);

            }
               Console.WriteLine("Diffrence Operation");
                h.ExceptWith(p);
                foreach(var a in h){
                Console.WriteLine(a);

            }
            


        }
    }
}

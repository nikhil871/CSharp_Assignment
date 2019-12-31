using System;
using System.Collections.Generic;
namespace SortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
           SortedSet<int> s= new SortedSet<int>();
           s.Add(25);
           s.Add(23);
           s.Add(21);
           s.Add(26);
           SortedSet<int> p= new SortedSet<int>();
           p.Add(25);
            p.Add(31);
             p.Add(32);
              p.Add(33);
           foreach(int a in s){
               Console.WriteLine(a);

           }   
           Console.WriteLine("Union");
           s.IntersectWith(p);
            foreach(int a in s){
               Console.WriteLine(a);

           }   
           
        }
    }
}

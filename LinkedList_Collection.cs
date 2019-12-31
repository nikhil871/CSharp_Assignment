using System;
using System.Collections.Generic;


namespace LinkedList_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> l= new LinkedList<int>();
            l.AddLast(25);
            l.AddLast(33);
            l.AddLast(32);
            foreach(int a in l){
                Console.WriteLine(a); 
            }
            Console.WriteLine("after removing");
            l.RemoveFirst();
             foreach(int a in l){
                Console.WriteLine(a); 
            }
             l.AddLast(25);
            l.AddLast(32);
            l.AddLast(33);
            Console.WriteLine("after removing");
            l.RemoveLast();
             foreach(int a in l){
                Console.WriteLine(a); 
            }
             l.AddLast(25);
            l.AddLast(32);
            l.AddLast(33);
              Console.WriteLine("after removing");
            l.Remove(33);
             foreach(int a in l){
                Console.WriteLine(a); 
            }

    
        }
    }
}

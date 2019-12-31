using System;
using System.Collections.Generic;

namespace List_Collection
{
    class List
    {
       public static void Main(string[] args){
           List<int> list= new List<int>();
           list.Add(25);
           list.Add(23);
           list.Add(29);
           list.Add(25);
           list.Add(21);
           list.Add(20);
           foreach(int a in list){
               Console.WriteLine(a);
           }
           list.Sort();
           // after sorting
           Console.WriteLine("After sorting");
            foreach(int a in list){
               Console.WriteLine(a);
           }
           Console.WriteLine(" after removing");
           list.Remove(23);
           Console.WriteLine(list[1]);
           list.RemoveAt(1);
        Console.WriteLine(list[1]);
        list.RemoveRange(0,1);
          foreach(int a in list){
               Console.WriteLine(a);
           }
           





       }
    }
}

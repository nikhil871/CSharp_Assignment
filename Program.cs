using System;
using System.Collections;
namespace ArrayList_Collection
{
    class Program
    {
        static void Main(string[] args)

        {
            Program p= new Program();

            ArrayList arrayList= new ArrayList(); 
            arrayList.Add("Arun");
            arrayList.Add(25);
            arrayList.Add('b');
            arrayList.Add(p);
            foreach(dynamic d in arrayList){
                Console.WriteLine(d);
            }
           
         Console.WriteLine("After removing");
         arrayList.Remove(25);
          foreach(dynamic d in arrayList){
                Console.WriteLine(d);
            }
            Console.WriteLine("After removing");
         arrayList.RemoveRange(0,1);
          foreach(dynamic d in arrayList){
                Console.WriteLine(d);
            }
            Console.WriteLine("Capacity : "+arrayList.Capacity);
             Console.WriteLine("Count : "+arrayList.Count);

        }
    }
}

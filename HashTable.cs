using System;
using System.Collections;
namespace HashTable_Collecitons
{
    class Program
    {
        static void Main(string[] args)
        {
           Hashtable hashtable= new Hashtable();
           hashtable.Add(1,2);
           hashtable.Add(2,2);
           hashtable.Add(3,2);
           hashtable.Add(4,2);
           ArrayList list= new ArrayList(hashtable.Keys);
           list.Reverse();
           foreach(int a in list){
               Console.WriteLine(a+":"+ hashtable[a]);
           }

        }
    }
}

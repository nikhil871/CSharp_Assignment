using System;
using System.Collections.Generic;
namespace Dictionary_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> ds = new Dictionary<int, string>();
            ds.Add(1, "Arun");
            ds.Add(2, "Jayesh");
            ds.Add(3, "Nikhil");

            ds.Add(4, "Mayur");
            foreach (KeyValuePair<int, string> e in ds)
            {
                Console.WriteLine("{0} and {1}", e.Key, e.Value);
            }
            // remove 
            ds.Remove(2);
            Console.WriteLine("After removing ");
            foreach (KeyValuePair<int, string> e in ds)
            {
                Console.WriteLine("{0} and {1}", e.Key, e.Value);
            }
            ds.Add(2, "Jayesh");

            if(ds.ContainsValue("Mayur")){
                Console.WriteLine("it contains mayur ");
            }

           //  gets Keys 
            Dictionary<int ,string>.KeyCollection key = ds.Keys ; 

            // gets value

            Dictionary<int, string>.ValueCollection value = ds.Values ;



        }
    }
}

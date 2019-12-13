using System;
namespace SwitchCase{
class SwitchStatement{
 public static void Main(string[] args){   
 Console.WriteLine("Enter number 1-9 to be  in word");
 int ch = Convert.ToInt16(Console.ReadLine());
 switch (ch)
 {
     case 1:
     Console.WriteLine("one");
     break;
     case 2:
     Console.WriteLine("two");
     break;
     case 3:
     Console.WriteLine("three");
     break;
     case 4:
     Console.WriteLine("four");
     break;
     case 5:
     Console.WriteLine("five");
     break;
     default:
     Console.WriteLine("wrong chooise");
     break;

 }

     int[] a= {1,2,3,4,5,6};
     foreach(int k in a){
         Console.WriteLine(k);
     } 
 }

}


}
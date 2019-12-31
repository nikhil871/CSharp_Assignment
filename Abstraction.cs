using System;

namespace Abstraction
{
    public abstract class  Processor{
public abstract void Core();
public void process(){
    Console.WriteLine("processing");
}
    }
    public class Laptop : Processor
    {
        public override void Core(){
Console.WriteLine("four cores");
}
        static void Main(string[] args)
        {
           Processor ps = new Laptop();
             ps.Core();
    }
}
}

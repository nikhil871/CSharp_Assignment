using System;

namespace Inheritance
{
    class A{
private int id;
        private string name;

        public int getId()
        {
            return this.id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public string getName()
        {
            return this.name;
        }

        public void setName(string name)
        {
            this.name = name;
        }


    
    
        
    }
    class B : A {
static void Main(string[] args)
        {
        B b = new B();
        b.setId(10);
b.setName("Arun");
Console.WriteLine(b.getId());
Console.WriteLine(b.getName());

        }
    }
}

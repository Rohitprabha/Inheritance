using System;

namespace Hierarchical_Inheritance
{
    class Father
    {
        public void display()
        {
            Console.WriteLine("Father");
        }
    }
    class Son : Father
    {
        public void display1()
        {
            Console.WriteLine("son");
        }
    }
    class Daughter : Father
    {
        public void display2()
        {
            Console.WriteLine("Daughter");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Father f = new Father();
            f.display();
            Son s = new Son();
            s.display();
            s.display1();
            Daughter d = new Daughter();
            d.display();
            d.display2();
        }
    }
}

using System;

namespace Inheritance_Example
{
    public class ParentClass
    {
        public ParentClass()
        {
            Console.WriteLine("ParentClass Constructor called");
        }
    }
    public class ChildClass : ParentClass
    {
        public ChildClass()
        {
            Console.WriteLine("ChildClass Constructor called");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ChildClass cc = new ChildClass();
        }
    }
}

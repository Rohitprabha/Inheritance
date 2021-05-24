using System;

namespace Multiple_Inheritance
{

    interface ICustomer1
    {
        void print();

    }
    interface ICustomer2
    {
        void Display();
    }
    class ClassA : ICustomer1, ICustomer2                          //class can inherit from more than one interface at the same time
    {
        public void print()
        {
            Console.WriteLine("print method from ClassA implimenting interface ICustomer1");
        }
        public void Display()
        {
            Console.WriteLine("print method from ClassA implimenting interface ICustomer2");
        }
    }
    class ClassB
    {

    }
    class Program : ClassA
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Display();
            p.print();
        }
    }
    //class Program : ClassA, ClassB                               //Error Class 'Program' cannot have multiple base classes: 'ClassA' and 'ClassB'
    //{
    //    static void Main(string[] args)
    //    {
    //        ClassA a = new ClassA();
    //        a.print();
    //        a.Display();
    //    }
    //}
}

using System;

namespace Hybrid_Inheritance
{
    interface IGrandparents
    {
        void grandparents();
    }

    interface IFather : IGrandparents
    {
        void father();
    }

    interface IMother : IGrandparents
    {
        void mother();
    }

    class Son : IFather, IMother
    {
        public void grandparents()
        {
            Console.WriteLine("Grand Parents interface");
        }
        public void father()
        {
            Console.WriteLine("Father interface");
        }
        public void mother()
        {
            Console.WriteLine("Mother interface");
        }
        public void son()
        {
            Console.WriteLine("Son Class");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Son s = new Son();
            s.grandparents();
            s.father();
            s.mother();
            s.son();
        }
    }
}

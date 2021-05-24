using System;

namespace Inheritance
{
    class Vehicle                                   // base class (parent) 
    {
        public string brand = "Yamaha";             // Vehicle field
        public void sound()                         // Vehicle method 
        {
            Console.WriteLine("Duur, Duur!");
        }
    }

    class Bike : Vehicle                            // derived class (child)
    {
        public string modelName = "R15";            // Bike field
    }

    class Program
    {
        static void Main(string[] args)
        {
            Bike myBike = new Bike();
            myBike.sound();                             // Call the sound() method From the Vehicle class
            Console.WriteLine(myBike.brand);            // value of the brand field from the Vehicle class
            Console.WriteLine(myBike.modelName);        //value of the modelName from the Bike class
        }
    }
}

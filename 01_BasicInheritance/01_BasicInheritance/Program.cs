using System;

namespace _01_BasicInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Exploring Inheritance ****");
            Car MyCar = new Car(80);

            MyCar.Speed = 50;
            Console.WriteLine("My car is going at {0} Kmh", MyCar.Speed);

            MiniVan MyMini = new MiniVan();
            MyMini.Speed = 10;
            Console.WriteLine("MyMini is going at {0} Kmh", MyMini.Speed);
        }
    }
}

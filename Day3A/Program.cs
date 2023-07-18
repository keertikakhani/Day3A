using System;

namespace Day3A
{
    class Program
    {
        public static void Main(string[] args)
        {
            Car car = new Car();
            Console.WriteLine(car.color);

            Dog d = new Dog();
            d.Eat();
            d.Bark();


            Console.ReadLine();
        }
    }
}

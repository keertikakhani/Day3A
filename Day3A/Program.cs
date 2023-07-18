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

            Addition addition = new Addition();
            addition.Add(23, 25);
            addition.Add(1.2, 1.5, 1.7);

            Father father = new Son();
            father.DisplayMessage();
            
            

            Console.ReadLine();
        }
    }
}

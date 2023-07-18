using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3A
{
    public class Polymorphism
    {
        public void Example()
        {
            Console.WriteLine("Polymorphism concept example");
        }
    }
   
    // Method Overloading Example
    public class Addition
    {
         public void Add(int a, int b)
         {
            int c = a + b;
            Console.WriteLine("sum is : " +c);
         }

        public void Add(double a, double b, double c)
        {
            double d = a + b + c;
            Console.WriteLine("sum is : " +d);
        }
    
    }

    // Method overriding Example

    public class Father
    {
        public virtual void DisplayMessage()
        {
            Console.WriteLine("I am the father");
        }
    }

    public class Son : Father
    {
        public override void DisplayMessage()
        {
            Console.WriteLine(" I am the son");

        }
    }

}

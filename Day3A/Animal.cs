﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3A
{
    // Inheritance
    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating");
        }
    }

    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Barking");
        }
    }


}

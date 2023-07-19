using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3A
{
    public abstract class Operation
    {
        public abstract void ATMOperation();

        public void Display(long a)
        {
            Console.WriteLine("Balance : " +a);
        }
    }

    public class Bank : Operation
    {
        public override void ATMOperation()
        {
            Console.WriteLine("Connecting to the bank");
        }
    }
}

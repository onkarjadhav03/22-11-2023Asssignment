using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment18Interface
{
    internal class Program
    { 
   
        static void Main(string[] args)
        {
            Laptop laptop = new Laptop();
            Console.WriteLine("Is the laptop connected?\t" + laptop.Connect());
            Console.WriteLine("Time taken to charge the laptop is"+laptop.charge(50)+"min");
            Console.WriteLine("Laptop details" + laptop.display());

            Smartphone smartphone = new Smartphone();
            Console.WriteLine("Is the smartphone connected?\t" + smartphone.Connect());
            Console.WriteLine("Time taken to charge the laptop is" + smartphone.charge(50) + "min");
            Console.WriteLine("Laptop details" + smartphone.display());

        }
    }
}

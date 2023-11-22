using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment18Interface
{
    public class Smartphone : IConnactable, IRechargable, IDisplable
    {

        bool isconnected;
        int chtime;
        string details;

        public bool Connect()
        {
            Console.WriteLine("enter if smartphone is connected");
            isconnected = Boolean.Parse(Console.ReadLine());
            return isconnected;

        }

        public int charge(int min)
        {
            Console.WriteLine("enter if smartphone chargein time");
            chtime = int.Parse(Console.ReadLine());
            return chtime;
        }
        public string display()
        {
            Console.WriteLine("Enter your smartphone details");
            details = Console.ReadLine();
            return details;
        }
    }
}

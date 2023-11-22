using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment18Interface
{
    public class Laptop : IConnactable, IRechargable, IDisplable
    {
        bool isconnected;
        int chtime;
        string details;

        public bool Connect()
        {
            Console.WriteLine("enter if laptop is connected");
            isconnected = Boolean.Parse(Console.ReadLine());
            return isconnected;

        }

        public int charge(int min)
        {
           chtime=min;
            return chtime;
        }
        public string display()
        {
            Console.WriteLine("Enter your laptop details");
            details= Console.ReadLine();
            return details;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
        public bool HasHandlebar { get; set; }  
        public override void DriveAbstract()
        {
            Console.WriteLine("This is completely impractical unless you fancy yourself a modern-day cowboy.");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine("You're not a cowboy..");  
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Car : Vehicle
    {
        public bool HasSteeringWheel { get; set; }  
        public override void DriveAbstract()
        {
            Console.WriteLine("This is the way..");
        }
    }
}

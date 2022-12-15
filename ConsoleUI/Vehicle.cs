﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal abstract class Vehicle
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        
        public abstract void DriveAbstract();
        public virtual void DriveVirtual() 
        {
            Console.WriteLine("This is my virtual mode of transportation.");
        }
    }

}

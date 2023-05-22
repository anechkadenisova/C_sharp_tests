﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_7
{
    internal class Cleaner : Employee, ICleanable
    {
        public Cleaner(string name) : base(name) 
        {

        }

        public void Clean()
        {
            Console.WriteLine("Cleaner is cleaning");
        }

        public override string ToString()
        {
            return $"This man is a cleaner. His name is {Name}";
        }
    }
}

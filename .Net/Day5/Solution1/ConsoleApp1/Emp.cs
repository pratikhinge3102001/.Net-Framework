﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Emp:Person
    {
        //public override void Display()
        public new void Display()
        {
            Console.WriteLine("In Emp class Method");
        }
    }
}

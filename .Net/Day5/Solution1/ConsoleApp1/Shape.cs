using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Shape
    {
        protected Shape() {
            Console.WriteLine("In Shape  Constructor");
        }

        public abstract void CalculateArea();

        public void CalculatePeremeter()
        {
            Console.WriteLine("In Peremeter Method");
        }
    }
}

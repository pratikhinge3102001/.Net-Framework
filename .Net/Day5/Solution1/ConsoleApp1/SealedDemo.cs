using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public sealed class SealedDemo
    {
        public int data {  get; set; }
        public SealedDemo() {
            Console.WriteLine("Sealed Constructor");
        }
        public SealedDemo(int _data)
        {
            data=_data;
            Console.WriteLine("Sealed Parametrised Constructor");
        }
    }

    //Error: You can not inherit the Sealed class
   /* class Myclass : SealedDemo
    {
    }*/
}

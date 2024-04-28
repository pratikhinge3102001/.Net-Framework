using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    public delegate void DelCalculation(int a, int b);
    internal class MultiCastDelDemo
    {
        public static void Add(int a, int b)
        {
            Console.WriteLine("Addition: " + (a + b));
        }
        public static void Sub(int a, int b)
        {
            Console.WriteLine("Subtraction: " + (a - b));
        }
        public static void Multi(int a, int b)
        {
            Console.WriteLine("Multiplication: " +(a * b));
        }

        static void Main_2(string[] args)
        {
            //Multicast delegate
            DelCalculation d = Add;
            d += Sub;
            d += Multi;

            //Invoke
            d(12, 4);
            Console.WriteLine("-------------");
            d(15, 3);
            Console.WriteLine("After removing ref -------------");
            d -= Multi;
            d(15, 3);
        }
    }
}

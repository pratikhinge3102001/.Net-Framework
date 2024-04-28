using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    public delegate void AnonymousDelegate(int a,int b);
    internal class AnonymousMethodAndLambda
    {
        static void Main_3(string[] args)
        {
            //Anonymous Functions
            AnonymousDelegate ad = delegate (int a, int b)
            {
                Console.WriteLine(a+b);
            };

            ad += delegate (int a, int c)
            { Console.WriteLine(a - c); };


            ad(10,2);

            //Lambda 
            Console.WriteLine("----------------------");
            ad += (a, b) => { Console.WriteLine(a*b); };
            ad(5, 3);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_18Dec
{
    internal class SwichDemo
    {
        static void Main4(string[] args)
        {
            int no = int.Parse(Console.ReadLine());
            switch (no)
            {
                case 0:
                    Console.WriteLine("Zero");
                    break;
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                default: 
                    Console.WriteLine("default Case");
                    break;
                
            }
        }
        
    }
}

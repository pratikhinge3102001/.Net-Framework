using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIIDemo
{
    internal class OutAndRefDemo
    {
        
        static void Main_outref(string[] args)
        {
            
            int a=10; int b=20; //Must initialise
          
            //Console.WriteLine($"Before Swap a:{a} - b: {b}");
            swap(ref a, ref b);
            Console.WriteLine($"After Swap a:{a} - b: {b}");
            Console.WriteLine("\n");
            int add, sub, mult;//No need to initialised
            Calculate(a,b, out add, out sub, out mult);
            Console.WriteLine($"{add} {sub} {mult}");
        }

        private static void Calculate(int a, int b, out int add, out int sub, out int mult)
        {
            add = a + b;
            sub = a-b;
            mult = a*b;
            
        }

        private static void swap(ref int a,ref int b)
        {
            int temp = a;
            a=b; 
            b=temp;
        }
    }
}

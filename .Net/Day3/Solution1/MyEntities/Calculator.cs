using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEntities
{
    public class Calculator
    {
        public void Add(int a, int b,int c=0)
        {
            Console.WriteLine(a + b +c );
        }

        public void Display(int id,string nm) { 
            Console.WriteLine(id +"  "+ nm); 
        }

        //params method
        public int Sum(params int[] arr) {
            int sum = 0;
            foreach (int i in arr)
            {
                sum += i;
            }
            return sum;
        }

        //Overloaded
        public void Add(int a, float b, float c = 0.0f)
        {
            Console.WriteLine(a + b + c);
        }
    }
}

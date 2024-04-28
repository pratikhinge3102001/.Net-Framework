using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_18Dec
{
    internal class DemoOfDynamicandVar
    {
        public dynamic Add(int x, int y) //getting error for var
        {
            return x + y;
        }

        static void Main6(string[] args)
        {
            var no11 = 10;
            // no = "radha";
            dynamic no1 = 10;
            no1 = "five";// No error

            string no=Console.ReadLine();
            int data;
            if(int.TryParse(no, out data))
            {
                Console.WriteLine(data);
            }
            else
            {
                Console.WriteLine("Else Part");
                Console.WriteLine(data);
            }

            Console.WriteLine("Enter Boolean value");
            bool res = bool.Parse(Console.ReadLine());
            Console.WriteLine(res);
        }
    }
}

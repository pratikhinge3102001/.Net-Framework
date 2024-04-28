using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miscellanious
{

    internal class OperatorOverloading
    {
        public int No { get; set; }
        public OperatorOverloading() {
            No = 0;
        }
        public OperatorOverloading(int no) {
            No = no;
        }
        public override string ToString()
        {
            return $"{No}";
        }

        public static OperatorOverloading operator ++(OperatorOverloading obj)
            {
             return new OperatorOverloading(obj.No++);
            }

        public static OperatorOverloading operator --(OperatorOverloading obj)
        {
            return new OperatorOverloading(obj.No--);
        }
        public static OperatorOverloading operator -(OperatorOverloading obj)
        {
            return new OperatorOverloading(-obj.No);
        }

        public static OperatorOverloading operator +(OperatorOverloading obj1, OperatorOverloading obj2)
        {
            return new OperatorOverloading(obj1.No + obj2.No);
        }
        public static bool operator ==(OperatorOverloading obj1, OperatorOverloading obj2)
        {
            return obj1.No == obj2.No;
        }
        public static bool operator !=(OperatorOverloading obj1, OperatorOverloading obj2)
        {
            return obj1.No != obj2.No;
        }



        static void Main(string[] args)
        {
            Console.WriteLine();
            OperatorOverloading obj = new OperatorOverloading(5);
            Console.WriteLine("++ Operator:");
            Console.WriteLine("Before: "+obj);
            Console.WriteLine("After :"+ obj++);

            Console.WriteLine("-- Operator:");
            Console.WriteLine("Before: " + obj);
            Console.WriteLine("After :" + obj--);

            Console.WriteLine("- Operator:");
            Console.WriteLine("Before: " + obj);
            Console.WriteLine("After :" + -obj);

            Console.WriteLine("+ Operator:");
            OperatorOverloading obj1 = new OperatorOverloading(15);
            OperatorOverloading obj2 = new OperatorOverloading(5);
            Console.WriteLine("Before1: " + obj1);
            Console.WriteLine("Before2: " + obj2);
            Console.WriteLine("After :" + (obj1+obj2));


            Console.WriteLine("== and != Operator:");
            
            Console.WriteLine("Before1: " + obj1);
            Console.WriteLine("Before2: " + obj2);
            Console.WriteLine("After == :" + (obj1 == obj2));
            Console.WriteLine("After != :" + (obj1 != obj2));


        }


    }
}

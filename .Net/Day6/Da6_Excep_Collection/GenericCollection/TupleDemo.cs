using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollection
{
    internal class TupleDemo
    {
        static void Main(string[] args)
        {
            //Create Tuple
            Tuple<int, string> t = new Tuple<int, string>(1, "xyz");
            Console.WriteLine(t.Item1 + " "+t.Item2);
            
            //Create Tuple
            Tuple<int,int ,int > t1 = Tuple.Create(1, 2,3);
            Console.WriteLine(t1.Item1 + " " + t1.Item2 + " "+ t1.Item3);


            Tuple<int, int, int> res = Calculation(2, 4);
            Console.WriteLine("Addition : " + res.Item1+ "Subtraction : " + res.Item2+ "Multiplication : " + res.Item3);

            Tuple<int, int, int> res1 = Calculation1(t1);
            Console.WriteLine("Addition : " + res1.Item1 + "Subtraction : " + res1.Item2 + "Multiplication : " + res1.Item3);


        }

        private static Tuple<int, int, int> Calculation1(Tuple<int, int, int> t1)
        {
            int add = t1.Item1+t1.Item2+t1.Item3;
            int sub = t1.Item1 - t1.Item2 - t1.Item3;
            int mult = t1.Item1 * t1.Item2 * t1.Item3;
            return Tuple.Create(add, sub, mult);
        }

        private static Tuple<int, int, int> Calculation(int v1, int v2)
        {
           return  new Tuple<int,int,int>(v1+v2,v1-v2,v1*v2);
        }
    }
}

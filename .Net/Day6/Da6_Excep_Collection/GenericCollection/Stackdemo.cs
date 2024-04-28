using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollection
{
    internal class Stackdemo
    {
        static void Main_4(string[] args)
        {
            Stack<int> obj = new Stack<int>();
            //Insert
            obj.Push(1);
            obj.Push(2);
            obj.Push(3);
            obj.Push(4);
            obj.Push(5);

            //Display
            foreach (var item in obj)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Removing elements");
            Console.WriteLine(obj.Pop());
            Console.WriteLine(obj.Pop());

            Console.WriteLine("\n");
            //Display
            foreach (var item in obj)
            {
                Console.WriteLine(item);
            }
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    internal class QueueDemo
    {
        static void Main_3(string[] args)
        {
            Queue qobj = new Queue();
            //Insert
            qobj.Enqueue(1);
            qobj.Enqueue(2);
            qobj.Enqueue(3);
            qobj.Enqueue(4);
            qobj.Enqueue(5);

            //Display
            foreach (var item in qobj)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Removing elements");
            Console.WriteLine(qobj.Dequeue());
            Console.WriteLine(qobj.Dequeue());

            Console.WriteLine("\n");
            //Display
            foreach (var item in qobj)
            {
                Console.WriteLine(item);
            }
        }
    }
}

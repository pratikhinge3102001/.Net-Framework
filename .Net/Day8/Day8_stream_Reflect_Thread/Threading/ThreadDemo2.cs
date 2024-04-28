using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadingDemo
{
    internal class ThreadDemo2
    {
        static void Main_2(string[] args)
        {
            //  Thread t = new Thread(Print);
            Thread t = new Thread(()=>Print(15));
            t.Start();

            Console.WriteLine("Main Method");
            for (int i = 15; i < 25; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine(i);
            }
        }

        static void Print(int data)
        {
            for (int i = 0; i < data; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
        }
    }
}

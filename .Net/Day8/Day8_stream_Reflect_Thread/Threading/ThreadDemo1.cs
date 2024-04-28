using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadingDemo
{
    internal class ThreadDemo1
    {
        static void Main_4(string[] args)
        {
            //  Thread t = new Thread(Print);
            Thread t = new Thread(new ThreadStart(Print));
            t.Start();

            Console.WriteLine("Main Method");
            for (int i = 15; i < 25; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine(i);
            }
        }

        static void Print()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadingDemo
{
    internal class MultipleThreadDemo
    {
        static void Main_6(string[] args)
        {
            MultipleThreadDemo mt = new MultipleThreadDemo();
            Thread t = new Thread(() => mt.Display(1, 20));
            Thread t2 = new Thread(() => mt.Display(21, 40));
            Thread t3 = new Thread(() => mt.Display(41, 60));

            t.Name = "Test";
            t2.Name = "Test1";
            t3.Name = "Test2";

            t.Start();
            t2.Start();
            t3.Start();

            t.Join();
            t2.Join();
            t3.Join();

            Console.WriteLine("Main Method Executed Successfully!!");

        }
        public void Display(int start, int end)
        {
            for (int i = start; i < end; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name + " : " +i);
                Thread.Sleep(1000);
            }
        }
    }
}

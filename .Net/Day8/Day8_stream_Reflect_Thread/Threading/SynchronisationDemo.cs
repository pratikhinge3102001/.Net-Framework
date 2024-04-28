using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadingDemo
{
    internal class SynchronisationDemo
    {
        static void Main(string[] args)
        {
            SynchronisationDemo mt = new SynchronisationDemo();
            SynchronisationDemo mt1 = new SynchronisationDemo();
            SynchronisationDemo mt2 = new SynchronisationDemo();
            Thread t = new Thread(mt.Display1);
            Thread t2 = new Thread(mt.Display1);
            Thread t3 = new Thread(mt.Display1);

            t.Name = "Test23";
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
        public void Display1()
        {
            
            lock(this)
            {
                for (int i = 1; i < 10; i++)
                {
                    Console.WriteLine(Thread.CurrentThread.Name + " : " + i);
                    Thread.Sleep(1000);
                }
            }
        }
    }
}

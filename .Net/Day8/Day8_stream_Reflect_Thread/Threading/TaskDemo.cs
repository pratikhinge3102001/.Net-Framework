using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadingDemo
{
    internal class TaskDemo
    {
        static void Main_12(string[] args)
        {

            Task t = new Task(Print);
            t.Start();

            for (int i = 90; i < 100; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(2000);
            }
            Console.WriteLine("Main Method Execution completed");
        }
        public static void Print() { 
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i.ToString());
                Thread.Sleep(1000);
            }
        }
    }
}

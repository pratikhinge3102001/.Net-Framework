using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadingDemo
{
    internal class TaskDemo
    {
        static void Main_8(string[] args)
        {
            Task t = Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(i);
                }
            });

             Task<int> t1 = Task.Run(() => 
            {+
                int sum = 0;
                for (int i = 0; i < 10; i++)
                {
                    sum+=i;
                }
                return sum;
            });
            var val = t1.Result;
            Console.WriteLine(val);
            Thread.Sleep(5000);
        }
    }
}

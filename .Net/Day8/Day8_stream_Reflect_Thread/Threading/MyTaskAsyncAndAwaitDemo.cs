using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ThreadingDemo
{
    internal class MyTaskAsyncAndAwaitDemo
    {
        static void Main_13(string[] args)
        {
            LongProcess();
            shortProcess();
            Thread.Sleep(6000);
      }

        private static void shortProcess()
        {
            Console.WriteLine("Short Process Started !");
            Console.WriteLine("Short Process ended !");
        }

        private async static void LongProcess()
        {
            Console.WriteLine("Long Process Started !");
            //Thread.Sleep(4000);
            await Task.Delay(4000);
            Console.WriteLine("Long Process ended !");
        }
    }
}

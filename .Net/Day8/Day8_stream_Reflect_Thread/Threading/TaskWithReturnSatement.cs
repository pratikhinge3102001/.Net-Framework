using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadingDemo
{
    internal class TaskWithReturnSatement
    {
        static async Task Main_14(string[] args)
        {
            Task<int> t = Task.Run(LongProcess);
             shortProcess();
            int res = await t;
            Console.WriteLine(res);
            Thread.Sleep(6000);
        }

        private static void shortProcess()
        {
            Console.WriteLine("Short Process Started !");
            Console.WriteLine("Short Process ended !");
        }

        private async static Task<int> LongProcess()
        {
            Console.WriteLine("Long Process Started !");
            //Thread.Sleep(4000);
            await Task.Delay(4000);
            Console.WriteLine("Long Process ended !");
            return 10;
        }
    }
}

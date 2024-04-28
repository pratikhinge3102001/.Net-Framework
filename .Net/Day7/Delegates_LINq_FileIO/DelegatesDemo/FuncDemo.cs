using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    internal class FuncDemo
    {
        public string Print(string s)
        {
            return s.ToUpper();
        }
        static void Main_4(string[] args)
        {
          FuncDemo obj = new FuncDemo();
          Func<string, string> func = obj.Print;
          Console.WriteLine(func("welcome"));

          Func<int ,int ,int> func2 = (a,b)=>a*b;
            Console.WriteLine(func2(3,4));

            Func<string, string, string> func3 = delegate (string s, string s1)
            {
                return s + " " + s1;
            };
            Console.WriteLine(func3("welcome ","Students"));
        }
    }
}

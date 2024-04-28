using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    internal class ActionDemo
    {
        static void Main_5(string[] args)
        {
            Action<string> action = delegate (string s)
            {
                Console.WriteLine(s.ToUpper());
            };
            action += s => { Console.WriteLine(s.ToLower()); };

            action("WelCome");
        }
    }
}

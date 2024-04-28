using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    public delegate string MyDels(string s);
    internal class EventDemo
    {
        event MyDels myevent;
        public EventDemo()
        {
            myevent += new MyDels(Display);
        }
        public static string Display(string s)
        {
            return s.ToUpper();
        }
        static void Main(string[] args)
        {
            EventDemo demo = new EventDemo();
            string res= demo.myevent("welcome to knowIt");
            Console.WriteLine(res);
            
        }
    }
}

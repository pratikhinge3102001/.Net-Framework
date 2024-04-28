using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ChildOfMyclass: Myclass
    {
        public sealed override void Method1()
        {
            Console.WriteLine("In Child Method1");
        }

        public override void Method2()
        {
            Console.WriteLine("In Child Method2");
        }
    }
}
